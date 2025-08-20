using IMSBackend.Application.Contracts;
using IMSBackend.Application.Services;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.BusinessPitches;
using IMSBackend.Domain.Entities.Transactions;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SendGrid.Helpers.Mail;
using System.Text.RegularExpressions;

namespace IMSBackend.Application.Features.BusinessPitchFeatures.Command
{
    public class BusinessPitchCommandHandler : IRequestHandler<BusinessPitchCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaymentService _paymentService;
        private readonly IJobTestService _jobTestService;

        public BusinessPitchCommandHandler(IUnitOfWork unitOfWork, IPaymentService paymentService, IJobTestService  jobTestService)
        {
            _unitOfWork = unitOfWork;
            _paymentService = paymentService;
            _jobTestService = jobTestService;
        }
        public async Task<Result<string>> Handle(BusinessPitchCommand cmd, CancellationToken cancellationToken)
        {
            try
            {
                var payment = await _paymentService.GetTransactionStatus(cmd.Request.ReferenceNumber);

                Regex regex = new Regex(@"^([\w\.\-\+]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(cmd.Request.EmailAddress);
                if (!match.Success)
                {
                    return await Result<string>.FailureAsync("Invalid Email Address");
                }

                var CheckEmail = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.EmailAddress == cmd.Request.EmailAddress, cancellationToken);

                if (CheckEmail is not null)
                {
                    return await Result<string>.FailureAsync("Email address already exists");

                }

                string password = Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);
                var user = await _unitOfWork.AccountRepository.AddAsync(new Domain.Entities.Account.Account
                {
                    PasswordHashed = passwordHash,
                    PasswordSalt = passwordSalt,
                    EmailAddress = cmd.Request.EmailAddress,
                    FullName = cmd.Request.FullName,
                    UserType = UserTypeEnum.Pitch,
                    StatusEnum = StatusEnum.Active,
                    Address = cmd.Request.Address,
                    PhoneNumber = cmd.Request.PhoneNumber,
                    
                });
                await _unitOfWork.Save(cancellationToken);

                if (user is null)
                {
                    return await Result<string>.FailureAsync("fail to create");
                }

                var pitchPrice = await _unitOfWork.PitchPriceRepository
                  .GetQueryable()
                  .Select(p => p.Price)
                  .FirstOrDefaultAsync(cancellationToken);

                if (pitchPrice <= 0)
                {
                    return await Result<string>.FailureAsync("Pitch price not found or invalid.");
                }

                // ✅ Match expected vs actual amount from Flutterwave
                bool amountMatches = Math.Round(pitchPrice) == Math.Round(payment.data.amount);

                var pay = new Payment
                {
                    UserId = user.Id,
                    Amount = payment.data.amount,
                    Status = amountMatches
                    ? PaymentStatus.Successful.ToString()
                    : PaymentStatus.Incomplete.ToString(),
                    TransactionReference = cmd.Request.ReferenceNumber,
                    AmountExpected = pitchPrice,

                };
                await _unitOfWork.PaymentRepository.AddAsync(pay);
                await _unitOfWork.Save(cancellationToken);

                if (pay.Status == PaymentStatus.Successful.ToString())
                { 
                 var i =  await _unitOfWork.BusinessPitchRepository.AddAsync(new BusinessPitch
                {
                    AccountId = user.Id,
                    OwnersPicture = cmd.Request.Picture,
                    BusinessLogo = cmd.Request.Logo,
                    BusinessName = cmd.Request.BusinessName,
                    BusinessCategoryId = cmd.Request.BusinessCategoryId,
                    BusinessDescription = cmd.Request.BusinessDescription,
                });
                await _unitOfWork.Save(cancellationToken);
                    pay.TicketId = i.Id;
                    await _unitOfWork.PaymentRepository.Update(pay);
                    await _unitOfWork.Save(cancellationToken);
                }
                //Send email to user
                await _jobTestService.BusinessPitch(cmd.Request.EmailAddress, cmd.Request.FullName, payment.data.amount.ToString(), "Ibadan Youth Festival", cmd.Request.ReferenceNumber);

                return await Result<string>.SuccessAsync($"Pitched created successfully {user.Id}");
            }
            catch (Exception ex)
            {
                return await Result<string>.FailureAsync(ex.Message);
            }
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}

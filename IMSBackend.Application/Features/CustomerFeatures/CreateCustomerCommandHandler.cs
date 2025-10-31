using AutoMapper;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.Account;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace IMSBackend.Application.Features.CustomerFeatures
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Result<string>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Regex regex = new Regex(@"^([\w\.\-\+]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(request.Email);
                if (!match.Success)
                {
                    return await Result<string>.FailureAsync("Invalid Email Address");
                }
                var customer = await _unitOfWork.CustomerRepository.AddAsync(new Domain.Entities.CustomerDomain.Customer
                {
                    FullName = request.Name,
                    PhoneNumber = request.Phone,
                    Address = request.Address,
                    EmailAddress = request.Email,
                    IsAnonymous = request.IsAnonymous,
                });
                await _unitOfWork.Save(cancellationToken);

                if (customer != null && !request.IsAnonymous) 
                {

                    var CheckEmail = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.EmailAddress == request.Email, cancellationToken);

                    byte[] passwordHash, passwordSalt;

                    if (CheckEmail is not null)
                    {
                        CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);
                        var Updated = new Account
                        {
                            PasswordSalt = passwordSalt,
                            FullName = request.Name,
                            UserType = UserTypeEnum.Customer,
                            StatusEnum = StatusEnum.Active,
                            PasswordHashed = passwordHash
                        };
                        await _unitOfWork.AccountRepository.Update(Updated);
                        await _unitOfWork.Save(cancellationToken);
                        return await Result<string>.SuccessAsync("You have account with us but Customer Created Successfully");
                    }
                    CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);
                    //var user = _mapper.Map<Account>(request);
                    var user = new Account 
                    {
                        PasswordSalt = passwordSalt,
                        EmailAddress = request.Email,
                        FullName = request.Name,
                        UserType = UserTypeEnum.Customer,
                        StatusEnum = StatusEnum.Active,
                        PasswordHashed = passwordHash,
                    };
                    await _unitOfWork.AccountRepository.AddAsync(user);
                    await _unitOfWork.Save(cancellationToken);
                    return await Result<string>.SuccessAsync("Customer created successfully");
                }
                return await Result<string>.SuccessAsync("Successfully");
            }
            catch (Exception ex) 
            {
                return await Result<string>.FailureAsync("Error");
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

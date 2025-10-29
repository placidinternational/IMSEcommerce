using AutoMapper;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.Account;
using IMSBackend.Domain.Entities.Vendors;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace IMSBackend.Application.Features.VendorFeatures.Command.Create
{
    public class VendorCommandHandler : IRequestHandler<VendorCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public VendorCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Result<string>> Handle(VendorCommand request, CancellationToken cancellationToken)
        {
            try
            {

                Regex regex = new Regex(@"^([\w\.\-\+]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(request.EmailAddress);
                if (!match.Success)
                {
                    return await Result<string>.FailureAsync("Invalid Email Address");
                }

                var CheckEmail = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.EmailAddress == request.EmailAddress, cancellationToken);

                if (CheckEmail is not null)
                {
                    return await Result<string>.FailureAsync("Email address already exists");

                }
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);
                var user = new Account
                {
                    PasswordSalt = passwordSalt,
                    EmailAddress = request.EmailAddress,
                    PhoneNumber = request.PhoneNumber,
                    FullName = request.FullName,
                    Address = request.Address,
                    UserType = UserTypeEnum.Vendor,
                    StatusEnum = StatusEnum.Active,
                    PasswordHashed = passwordHash,
                };
                await _unitOfWork.AccountRepository.AddAsync(user);
                await _unitOfWork.Save(cancellationToken);

                var vendor = new Vendor
                {
                    AccountId = user.Id,
                    Fullname = request.FullName,
                    EmailAddress = request.EmailAddress,
                    CompanyName = request.CompanyName,
                    Address = request.Address,
                    PhoneNumber = request.PhoneNumber,
                    Logo = request.logo,
                    CategoryId = request.CategoryId,
                    Description = request.Description,
                    PassTaxToCustomer = request.PassTaxToCustomer
                };
                var data = await _unitOfWork.VendorsRepository.AddAsync(vendor);
                await _unitOfWork.Save(cancellationToken);
                if (data.Id != Guid.Empty)
                {
                    return await Result<string>.SuccessAsync($"Vendor created successfully {data.Id} ");
                }
                else
                {
                    return await Result<string>.FailureAsync("Failed to create vendor");
                }

              
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

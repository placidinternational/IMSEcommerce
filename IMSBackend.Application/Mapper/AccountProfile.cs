using AutoMapper;
using IMSBackend.Application.Features.AuthenticationFeature.Commands.Create;
using IMSBackend.Domain.Entities.Account;

namespace IMSBackend.Application.Mapper;
public class AccountProfile : Profile
{
    public AccountProfile()
    {
        CreateMap<Account, CreateAuthCommand>().ReverseMap();
   
    }
}

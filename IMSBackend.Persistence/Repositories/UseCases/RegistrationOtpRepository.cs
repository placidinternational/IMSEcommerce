using IMSBackend.Domain.Entities.Account;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;

namespace IMSBackend.Persistence.Repositories.UseCases;

public class RegistrationOtpRepository : Repository<RegistrationOtp>, IRegistrationOtpRepository
{
    private readonly IMSEcommerceContext _context;
    public RegistrationOtpRepository(IMSEcommerceContext _DbContext) : base(_DbContext)
    {
        _context = _DbContext;
    }
}

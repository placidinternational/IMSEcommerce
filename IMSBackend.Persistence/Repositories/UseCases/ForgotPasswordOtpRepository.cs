using IMSBackend.Domain.Entities.Account;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;

namespace IMSBackend.Persistence.Repositories.UseCases;
internal class ForgotPasswordOtpRepository : Repository<ForgotPasswordOtp>, IForgotPasswordOtpRepository
{
    private readonly IMSBackendContext _context;
    public ForgotPasswordOtpRepository(IMSBackendContext _DbContext) : base(_DbContext)
    {
        _context = _DbContext;
    }
}

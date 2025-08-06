using IMSBackend.Domain.UseCases;

namespace IMSBackend.Domain.Shared;

public interface IUnitOfWork : IDisposable
{
    IAccountRepository AccountRepository { get; }
    IRegistrationOtpRepository RegistrationOtpRepository { get; }
    IForgotPasswordOtpRepository ForgotPasswordOtpRepository { get; }
    INomineeRepository NomineeRepository { get; }
    Task<int> Save(CancellationToken cancellationToken);
}

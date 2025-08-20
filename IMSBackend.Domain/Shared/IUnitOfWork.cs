using IMSBackend.Domain.UseCases;

namespace IMSBackend.Domain.Shared;

public interface IUnitOfWork : IDisposable
{
    IAccountRepository AccountRepository { get; }
    IRegistrationOtpRepository RegistrationOtpRepository { get; }
    IForgotPasswordOtpRepository ForgotPasswordOtpRepository { get; }
    INomineeRepository NomineeRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    IVoteRepository VoteRepository { get; }
    IPaymentRepository PaymentRepository { get; }
    IPitchPriceRepository PitchPriceRepository { get; }
    IExibitionStandRepository ExibitionStandRepository {  get; }
    IBusinessPitchRepository BusinessPitchRepository { get; }
    Task<int> Save(CancellationToken cancellationToken);
}

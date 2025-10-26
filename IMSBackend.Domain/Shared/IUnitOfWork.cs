using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.IRepositories.UseCases;

namespace IMSBackend.Domain.Shared;

public interface IUnitOfWork : IDisposable
{
    IAccountRepository AccountRepository { get; }
    IRegistrationOtpRepository RegistrationOtpRepository { get; }
    IForgotPasswordOtpRepository ForgotPasswordOtpRepository { get; }
    IPaymentRepository PaymentRepository { get; }
    IBankDetailsRepository BankDetailsRepository { get; }
    IVendorCategoryRepository VendorCategoryRepository { get; }
    IVendorsRepository VendorsRepository { get; }
    IProductRepository ProductRepository {  get; }
    IEventRepository EventRepository {  get; }
    ITicketCategoryRepository TicketCategoryRepository {  get; }
    IProductCategoryRepository ProductCategoryRepository {  get; }
    Task<int> Save(CancellationToken cancellationToken);
}

using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.IRepositories.UseCases;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace IMSBackend.Domain.Shared;

public interface IUnitOfWork : IDisposable
{
    Task<IDbContextTransaction> BeginTransactionAsync(IsolationLevel isolationLevel, CancellationToken cancellationToken = default);
    IExecutionStrategy GetExecutionStrategy();
    IAccountRepository AccountRepository { get; }
    IRegistrationOtpRepository RegistrationOtpRepository { get; }
    IForgotPasswordOtpRepository ForgotPasswordOtpRepository { get; }
    IPaymentRepository PaymentRepository { get; }
    IBankDetailsRepository BankDetailsRepository { get; }
    IVendorsRepository VendorsRepository { get; }
    IProductRepository ProductRepository {  get; }
    IEventRepository EventRepository {  get; }
    ITicketCategoryRepository TicketCategoryRepository {  get; }
    IProductCategoryRepository ProductCategoryRepository {  get; }
    IOrderRepository OrderRepository {  get; }
    IOrderItemRepository OrderItemRepository { get; }
    ICustomerRepository CustomerRepository { get; }
    IVendorCustomerRepository VendorCustomerRepository {  get; }
    IBookedEventRepository BookedEventRepository {  get; }
    Task<int> Save(CancellationToken cancellationToken);
}

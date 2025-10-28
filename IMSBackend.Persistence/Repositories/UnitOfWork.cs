using IMSBackend.Domain.Shared;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;
using IMSBackend.Persistence.IRepositories.UseCases;
using IMSBackend.Persistence.Repositories.UseCases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace IMSBackend.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly IMSBackendContext _dbContext;
    private bool disposed;

    public UnitOfWork(IMSBackendContext dbContext) => _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));


    public Task<IDbContextTransaction> BeginTransactionAsync(IsolationLevel isolationLevel, CancellationToken cancellationToken = default)
    {
        return _dbContext.Database.BeginTransactionAsync(isolationLevel, cancellationToken);
    }
    private IAccountRepository _accountRepository;
    public IAccountRepository AccountRepository
    {
        get
        {
            if (_accountRepository == null)
            {
                _accountRepository = new AccountRepository(_dbContext);
            }
            return _accountRepository;
        }
    }

    private IRegistrationOtpRepository _registrationOtpRepository;
    public IRegistrationOtpRepository RegistrationOtpRepository
    {
        get
        {
            if (_registrationOtpRepository == null)
            {
                _registrationOtpRepository = new RegistrationOtpRepository(_dbContext);
            }
            return _registrationOtpRepository;
        }
    }

    private IForgotPasswordOtpRepository _forgotPasswordOtpRepository;
    public IForgotPasswordOtpRepository ForgotPasswordOtpRepository
    {
        get
        {
            if (_forgotPasswordOtpRepository == null)
            {
                _forgotPasswordOtpRepository = new ForgotPasswordOtpRepository(_dbContext);
            }
            return _forgotPasswordOtpRepository;
        }
    }

    private IPaymentRepository _paymentRepository;
    public IPaymentRepository PaymentRepository
    {
        get
        {
            if (_paymentRepository == null)
            {
                _paymentRepository = new PaymentRepository(_dbContext);
            }
            return _paymentRepository;
        }
    }
    private IBankDetailsRepository _bankDetailsRepository;
    public IBankDetailsRepository BankDetailsRepository
    {
        get
        {
            if (_bankDetailsRepository == null)
            {
                _bankDetailsRepository = new BankDetailsRepository(_dbContext);
            }
            return _bankDetailsRepository;
        }
    }

    private IVendorsRepository _vendorsRepository;
    public IVendorsRepository VendorsRepository
    {
        get
        {
            if (_vendorsRepository == null)
            {
                _vendorsRepository = new VendorsRepository(_dbContext);
            }
            return _vendorsRepository;
        }
    }
    private IProductRepository _productRepository;
    public IProductRepository ProductRepository
    {
        get
        {
            if (_productRepository == null)
            {
                _productRepository = new ProductRepository(_dbContext);
            }
            return _productRepository;
        }
    }

    private IEventRepository _eventRepository;
    public IEventRepository EventRepository
    {
        get
        {
            if (_eventRepository == null)
            {
                _eventRepository = new EventRepository(_dbContext);
            }
            return _eventRepository;
        }
    }

    private ITicketCategoryRepository _ticketCategoryRepository;
    public ITicketCategoryRepository TicketCategoryRepository
    {
        get
        {
            if (_ticketCategoryRepository == null)
            {
                _ticketCategoryRepository = new TicketCategoryRepository(_dbContext);
            }
            return _ticketCategoryRepository;
        }
    }
    private IProductCategoryRepository _productCategoryRepository;
    public IProductCategoryRepository ProductCategoryRepository
    {
        get
        {
            if (_productCategoryRepository == null)
            {
                _productCategoryRepository = new ProductCategoryRepository(_dbContext);
            }
            return _productCategoryRepository;
        }
    }

    private IOrderRepository _orderRepository;
    public IOrderRepository OrderRepository
    {
        get
        {
            if (_orderRepository == null)
            {
                _orderRepository = new OrderRepository(_dbContext);
            }
            return _orderRepository;
        }
    }

    private IOrderItemRepository _orderItemRepository;
    public IOrderItemRepository OrderItemRepository
    {
        get
        {
            if (_orderItemRepository == null)
            {
                _orderItemRepository = new OrderItemRepository(_dbContext);
            }
            return _orderItemRepository;
        }
    }

    private ICustomerRepository _customerRepository;
    public ICustomerRepository CustomerRepository
    {
        get
        {
            if (_customerRepository == null)
            {
                _customerRepository = new CustomerRepository(_dbContext);
            }
            return _customerRepository;
        }
    }

    private IVendorCustomerRepository _vendorCustomerRepository;
    public IVendorCustomerRepository VendorCustomerRepository
    {
        get
        {
            if (_vendorCustomerRepository == null)
            {
                _vendorCustomerRepository = new VendorCustomerRepository(_dbContext);
            }
            return _vendorCustomerRepository;
        }
    }

    private IBookedEventRepository _bookedEventRepository;
    public IBookedEventRepository BookedEventRepository
    {
        get
        {
            if (_bookedEventRepository == null)
            {
                _bookedEventRepository = new BookedEventRepository(_dbContext);
            }
            return _bookedEventRepository;
        }
    }
    public async Task<int> Save(CancellationToken cancellationToken)
    {
        return await _dbContext.SaveChangesAsync(cancellationToken);
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
        {
            if (disposing)
            {
                //dispose managed resources
                _dbContext.Dispose();
            }
        }
        //dispose unmanaged resources
        disposed = true;
    }
}

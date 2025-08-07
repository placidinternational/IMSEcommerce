using IMSBackend.Domain.Shared;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;
using IMSBackend.Persistence.Repositories.UseCases;

namespace IMSBackend.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly IMSBackendContext _dbContext;
    private bool disposed;

    public UnitOfWork(IMSBackendContext dbContext) => _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));


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

    private INomineeRepository _nomineeRepository;
    public INomineeRepository NomineeRepository
    {
        get
        {
            if (_nomineeRepository == null)
            {
                _nomineeRepository = new NomineeRepository(_dbContext);
            }
            return _nomineeRepository;
        }
    }


    private ICategoryRepository _categoryRepository;
    public ICategoryRepository CategoryRepository
    {
        get
        {
            if (_categoryRepository == null)
            {
                _categoryRepository = new CategoryRepository(_dbContext);
            }
            return _categoryRepository;
        }
    }

    private IVoteRepository _voteRepository;
    public IVoteRepository VoteRepository
    {
        get
        {
            if (_voteRepository == null)
            {
                _voteRepository = new VoteRepository(_dbContext);
            }
            return _voteRepository;
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

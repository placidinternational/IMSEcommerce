using IMSBackend.Domain.Common;
using IMSBackend.Domain.Entities.Account;

namespace IMSBackend.Domain.UseCases;
public interface IAccountRepository : IRepository<Account>
{
    Task<Account> Login(string emailaddress, string password, CancellationToken cancellationToken);
}

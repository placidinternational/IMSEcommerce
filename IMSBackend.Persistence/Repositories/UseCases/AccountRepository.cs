using Microsoft.EntityFrameworkCore;
using IMSBackend.Domain.Entities.Account;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;
using System.Text.RegularExpressions;

namespace IMSBackend.Persistence.Repositories.UseCases;
public class AccountRepository : Repository<Account>, IAccountRepository
{
    private readonly IMSBackendContext _context;
    public AccountRepository(IMSBackendContext _DbContext) : base(_DbContext)
    {
        _context = _DbContext;
    }


    public async Task<Account> Login(string emailaddress, string password, CancellationToken cancellationToken)
    {
        try
        {
            var user = await _context.Accounts.
                Where(x => x.EmailAddress.ToLower() == emailaddress.ToLower()).SingleOrDefaultAsync(cancellationToken);

            if (user == null)

                return null;
            else
            {
                if (!VerifyPassword(password, user.PasswordHashed, user.PasswordSalt))
                {
                    return null;
                }

                return user;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }


    private bool VerifyPassword(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
        {
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != passwordHash[i]) return false;
            }
            return true;
        }
    }
    public static bool ValidatePassword(string password)
    {
        try
        {
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$");
            var res = regex.Match(password).Success;
            if (!res) throw new Exception("Password is not valid! Password must be at least 8 characters and contain at least a small letter, a capital letter, a number and a special character");
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
}

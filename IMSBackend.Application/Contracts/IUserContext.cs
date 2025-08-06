using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Contracts;
public interface IUserContext
{
    bool IsAuthenticated { get; }
    Guid UserId { get; }
    string FullName { get; }
    string Role { get; }
}

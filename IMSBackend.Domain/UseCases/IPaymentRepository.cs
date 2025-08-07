using IMSBackend.Domain.Common;
using IMSBackend.Domain.Entities.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.UseCases
{
    public interface IPaymentRepository : IRepository<Payment>
    {

    }
}

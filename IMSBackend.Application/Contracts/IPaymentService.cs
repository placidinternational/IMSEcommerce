using IMSBackend.Application.Dtos.Flutterwave;
using IMSBackend.Common;
using IMSBackend.Domain.Entities.Award;
using IMSBackend.Domain.Entities.Transactions;

namespace IMSBackend.Application.Contracts
{
    public interface IPaymentService
    {
        Task<PaymentVerification> GetTransactionStatus(string tx_ref);
    
    }
}

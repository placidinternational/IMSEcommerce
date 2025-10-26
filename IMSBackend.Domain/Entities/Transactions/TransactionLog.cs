using IMSBackend.Common.Common;

namespace IMSBackend.Domain.Entities.Transactions;
public class TransactionLog : BaseEntity
{
    public Guid TransactionId { get; set; }
    public Transaction Transaction { get; set; }
    public string Log { get; set; }
}
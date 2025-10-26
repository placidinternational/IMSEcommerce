using IMSBackend.Common.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.Account;
using System.Transactions;

namespace IMSBackend.Domain.Entities.Transactions;

public class Transaction : BaseEntity
{
    public string TransactionNumber { get; set; }
    public TransactionEnum Status { get; set; }
    public TransactionType TransactionType { get; set; }
    public string PaymentMethod { get; set; }
    public decimal Amount { get; set; }
    public DateTime DatePaid { get; set; }
    public Guid? AgentId { get; set; }
    public Domain.Entities.Account.Account? Account { get; set; }
    public string  AgentNumber { get; set; }
    public string TransactionReference { get; set; } = string.Empty;
   // public string BillNumber { get; set; }
}



public enum TransactionType
{
    Invoice=1,
    Bills = 2,
}
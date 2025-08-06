using System.ComponentModel;

namespace IMSBackend.Common.Enums;

public enum TransactionStatusEnum : byte
{
    PENDING = 1,
    COMPLETED = 2,
    FAILED = 3,
    CANCELLED = 4,
    DISPUTE = 5,
    NEW = 6,
    [Description("IN-PROGRESS")]
    IN_PROGRESS = 7,
    REFUNDED
}

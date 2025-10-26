using IMSBackend.Common.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMSBackend.Common.Enums;


namespace IMSBackend.Domain.Entities.Transactions
{
    public class Payment : BaseEntity
    {
        [Required]
        public Guid UserId { get; set; }

        public Guid? VoteId { get; set; }
        public Guid? TicketId { get; set; }

        public Guid? ExibitionStandId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        public string TransactionReference { get; set; }
        public string Status { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountExpected { get; set; }
    }
}

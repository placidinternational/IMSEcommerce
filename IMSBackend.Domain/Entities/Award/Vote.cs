using IMSBackend.Common.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.Award
{
    public class Vote : BaseEntity
    {
        public Guid NomineeId { get; set; }
        public Nominee Nominee { get; set; }
        public int Quantity { get; set; }
        public Payment Payment { get; set; }
        public Guid PaymentId { get; set; }
        public decimal AmountPaid { get; set; }
        public string? VoterEmail { get; set; }
        public string? VoterName { get; set; }
        public string PaymentStatus { get; set; }
        public bool IsSuccessful { get; set; }

    }
}

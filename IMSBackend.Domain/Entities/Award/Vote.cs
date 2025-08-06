using IMSBackend.Common.Common;
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
        public int Quantity { get; set; }
        public decimal AmountPaid { get; set; }
        public string? VoterEmail { get; set; }
        public string? VoterName { get; set; }
    }
}

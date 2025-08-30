using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.NewFolder
{
    public class VotingResponse
    {
        public string Nominee { get; set; }
        public string VoterEmail { get; set; }
        public string VoterName { get; set; }
        public int Quantity { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime DateVoted { get; set; }
        public string Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.VotingDto
{
    public class AdminVoteMetric
    {
        public int TotalVoters { get; set; }
        public int TotalVotes { get; set; }
        public decimal Revenue { get; set; }
        public int TotalNominee { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.VotingDto
{
    public class VotingMetircDto
    {
        public int TotalVoters { get; set; }
        public int TotalNominees { get; set; }
        public int TotalCategories { get; set; }
    }
}

using IMSBackend.Domain.Entities.Award;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Persistence.Repositories.UseCases
{
    public class VoteRepository : Repository<Vote>, IVoteRepository
    {
        public VoteRepository(IMSBackendContext _DbContext) : base(_DbContext)
        {
        }
    }
}

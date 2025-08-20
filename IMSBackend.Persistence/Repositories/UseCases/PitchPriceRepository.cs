using IMSBackend.Domain.Entities.BusinessPitches;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Persistence.Repositories.UseCases
{
    public class PitchPriceRepository : Repository<PitchPrice>, IPitchPriceRepository
    {
        public PitchPriceRepository(IMSBackendContext _DbContext) : base(_DbContext)
        {
        }
    }
}

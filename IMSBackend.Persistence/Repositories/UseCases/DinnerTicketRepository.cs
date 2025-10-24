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
    public class DinnerTicketRepository : Repository<DinnerTicket>, IDinnerTicketRepository
    {
        public DinnerTicketRepository(IMSBackendContext _DbContext) : base(_DbContext)
        {
        }
    }
}

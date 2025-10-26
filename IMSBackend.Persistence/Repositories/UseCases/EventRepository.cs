using IMSBackend.Domain.Entities.EventDomain;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Persistence.Repositories.UseCases
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(IMSBackendContext _DbContext) : base(_DbContext)
        {
        }
    }
}

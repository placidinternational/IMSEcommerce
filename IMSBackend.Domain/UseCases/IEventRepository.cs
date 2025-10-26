using IMSBackend.Domain.Common;
using IMSBackend.Domain.Entities.EventDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.UseCases
{
    public interface IEventRepository : IRepository<Event>
    {
    }
}

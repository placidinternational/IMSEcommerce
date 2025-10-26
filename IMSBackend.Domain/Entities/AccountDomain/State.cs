using IMSBackend.Common.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.AccountDomain
{
    public class State : BaseEntity
    {
        public Country Country { get; set; }
        public Guid? CountryId { get; set; }
        public string Name { get; set; }
    }
}

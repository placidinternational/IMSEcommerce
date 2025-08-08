using IMSBackend.Common.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMSBackend.Domain.Entities.Account;

namespace IMSBackend.Domain.Entities.BusinessPitches
{
    public class BusinessPitch : BaseEntity
    {
        public string BusinessName { get; set; }
        public BusinessCategory BusinessCategory { get; set; }
        public Account Account { get; set; }
        public Guid AccountId { get; set; }
        public Guid BusinessCategoryId { get; set; }
        public string BusinessDescription { get; set; }
        public string BusinessLogo { get; set; }
        public string OwnersPicture { get; set; }
    }
}

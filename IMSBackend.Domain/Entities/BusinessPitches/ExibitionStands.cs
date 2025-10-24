using IMSBackend.Common.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.BusinessPitches
{
    public class ExibitionStands : BaseEntity
    {
        public string FullName { get; set; }
        public string BusinessName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string? InstagramHandle { get; set; }
        public string? TikTokHandle { get; set; }
        public string ExitibitionType { get; set; }
        public decimal Price { get; set; }
        public string? BrandLogo { get; set; }
        public string? SampleProduct { get; set; }
        public string? Picture { get; set; }
        public string ExitibionCode { get; set; }
    }
}

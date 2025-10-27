using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.VendorsDto
{
    public class GetAllFeaturedVendorsResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string Rating { get; set; }
        public bool IsFeaured { get; set; }
        public bool IsVerified { get; set; }
        public int NumberOfProducts { get; set; }
    }
}

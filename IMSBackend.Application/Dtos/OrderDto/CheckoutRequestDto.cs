using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.OrderDto
{
    public class CheckoutRequestDto
    {
        public Guid CustomerId { get; set; } 
        public List<CartItemDto> CartItems { get; set; } = new List<CartItemDto>();
        public string ReferenceNumber { get; set; }
    }
}

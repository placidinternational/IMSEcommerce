using IMSBackend.Application.Dtos.OrderDto;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.CheckoutFeatures
{

    public class ProcessProductOrderCommand : IRequest<Result<string>>
    {
        public  ProcessCheckoutCommand  CheckoutDto{ get; set; }
    }
public class ProcessCheckoutCommand
    {
        public Guid CustomerId { get; set; }
        public List<CartItemDto> CartItems {  get; set; }
        public string ReferenceNumber {  get; set; }
    }

}

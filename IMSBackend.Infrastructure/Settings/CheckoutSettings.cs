using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Infrastructure.Settings
{
    public class CheckoutSettings
    {
        public decimal TaxRate { get; set; }
        public decimal PaymentGatewayCharges { get; set; }
    }
}

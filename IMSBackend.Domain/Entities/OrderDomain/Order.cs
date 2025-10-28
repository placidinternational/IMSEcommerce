using IMSBackend.Common.Common;
using IMSBackend.Domain.Entities.CustomerDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.OrderDomain
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; } 

        // --- Financial Breakdown ---
        [Column(TypeName = "decimal(18,2)")]
        public decimal Subtotal { get; set; } // Total price before tax/fees
        [Column(TypeName = "decimal(18,2)")]
        public decimal TaxRate { get; set; } // The rate applied (e.g., 0.05 for 5%)
        [Column(TypeName = "decimal(18,2)")]
        public decimal TaxAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PaymentFeeRate { get; set; } // The rate applied for gateway fees
        [Column(TypeName = "decimal(18,2)")]
        public decimal FeeAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal FinalTotalPaid { get; set; } // Subtotal + Tax + Fees

        // Navigation property for items in the order
        public ICollection<OrderItem> Items { get; set; }
    }
}

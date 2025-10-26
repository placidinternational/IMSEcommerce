using IMSBackend.Common;
using IMSBackend.Domain.Entities.Product;
using IMSBackend.Domain.Entities.Vendors;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.ProductFeatures.Command.Create
{
    public class ProductCommand : IRequest<Result<string>>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public Guid ProductCategoryId { get; set; }
    }
}

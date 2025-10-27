using IMSBackend.Application.Dtos.ProductCategoryDto;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.ProductCategories.Querries
{
    public class GetAllProductCategoriesQuerry : IRequest<Result<IEnumerable<GetProductCategoryResponse>>>
    {
    }
}

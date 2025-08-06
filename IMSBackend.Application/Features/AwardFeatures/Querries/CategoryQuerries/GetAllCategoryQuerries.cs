using IMSBackend.Application.Dtos.CategoryDto;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.CategoryQuerries
{
    public class GetAllCategoryQuerries : IRequest<Result<List<CategoryResponse>>>
    {
    }
}

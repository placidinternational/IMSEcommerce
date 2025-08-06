using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Command.Categories
{
    public class CategoryCommand : IRequest<Result<string>>
    {
        public string Name { get; set; }
    }
}

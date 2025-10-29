using IMSBackend.Application.Dtos.EventDto;
using IMSBackend.Common;
using IMSBackend.Common.Extensions;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.EventFeatures.Querries
{
    public class GetAllEventsQueryHandler : IRequestHandler<GetAllEventsQuery, PaginatedResult<GetAllEventsDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllEventsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<PaginatedResult<GetAllEventsDto>> Handle(GetAllEventsQuery request, CancellationToken cancellationToken)
        {
            var events =  _unitOfWork.EventRepository.GetQueryable();

            var data =  await events.Select(a=>new GetAllEventsDto
            {
                Id = a.Id,
                EventDate = a.EventDate,
                Logo = a.Image,
                Address = a.VenueAddress,
                Title = a.Title
            }).ToPaginatedListAsync(request.PageNumber, request.PageSize, cancellationToken);
            return data;
        }
    }
}

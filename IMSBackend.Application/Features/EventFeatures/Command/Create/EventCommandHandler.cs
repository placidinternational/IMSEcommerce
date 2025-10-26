using IMSBackend.Application.Contracts;
using IMSBackend.Common;
using IMSBackend.Domain.Entities.EventDomain;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.EventFeatures.Command.Create
{
    public class EventCommandHandler : IRequestHandler<EventCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserContext _userContext;

        public EventCommandHandler(IUnitOfWork unitOfWork, IUserContext userContext)
        {
            _unitOfWork = unitOfWork;
            _userContext = userContext;
        }
        public async Task<Result<string>> Handle(EventCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var vendor = await _unitOfWork.VendorsRepository.GetSingleByExpression(x => x.AccountId == _userContext.UserId, cancellationToken);

                if (vendor == null) 
                {
                    return await Result<string>.SuccessAsync("Vendor not available");
                }

                var events =  await _unitOfWork.EventRepository.AddAsync(new Domain.Entities.EventDomain.Event
                {
                    Title = request.Title,
                    EventDate = request.EventDate,
                    EventTime = request.EventTime,
                    Description = request.Description,
                    Image= request.Image,
                    VenueName = request.VenueName,
                    VenueAddress = request.VenueAddress,
                    TotalCapacity= request.TotalCapacity,
                    CreatedBy = vendor.Id,
                    TicketCategories = request.TicketCategories.Select(x=>new TicketCategory                    {
                        Name = x.Name,
                        Price = x.Price,
                        Capacity = x.Capacity,
                        
                    }).ToList()
                });

                return await Result<string>.SuccessAsync("Event Added successfully");
            }
            catch (Exception ex) 
            {
                return await Result<string>.FailureAsync("Failed to create");
            }
        }
    }
}

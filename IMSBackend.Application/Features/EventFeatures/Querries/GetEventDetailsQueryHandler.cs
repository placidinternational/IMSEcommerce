using IMSBackend.Application.Dtos.EventDto;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using IMSBackend.Infrastructure.Settings;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace IMSBackend.Application.Features.EventFeatures.Querries
{
    public class GetEventDetailsQueryHandler : IRequestHandler<GetEventDetailsQuery, Result<EventDetailsDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CheckoutSettings _settings;

        public GetEventDetailsQueryHandler(IUnitOfWork unitOfWork, IOptions<CheckoutSettings> settings)
        {
            _unitOfWork = unitOfWork;
            _settings = settings.Value;
        }
        public async Task<Result<EventDetailsDto>> Handle(GetEventDetailsQuery request, CancellationToken cancellationToken)
        {
            // 1. Fetch Event with Categories and Vendor in a single, efficient query.
            var eventQuery = _unitOfWork.EventRepository.GetQueryable()
               .Where(e => e.Id == request.EventId)
               .Include(v => v.Vendor) // Include Vendor to get PassTaxToCustomer setting
               .Include(e => e.TicketCategories)
               .AsNoTracking();

            var eventEntity = await eventQuery.FirstOrDefaultAsync(cancellationToken);

            if (eventEntity == null)
            {
                // Returning null or throwing a NotFound exception is common practice
                return await Result<EventDetailsDto>.FailureAsync("No event found with this Id");
            }

            // --- Determine Tax Application ---
            // Now we can safely access eventEntity.Vendor since it was included in the query.
            bool passTaxToCustomer = eventEntity.Vendor.PassTaxToCustomer;
            decimal applicableTaxRate = _settings.TaxRate; // Use the configured global tax rate

            // 2. Aggregate Tickets Sold for all Categories in this Event
            var categoryIds = eventEntity.TicketCategories.Select(tc => tc.Id).ToList();

            // NOTE: Changing repository name from BookedEventRepository to IBookedTicketRepository 
            // to match previous conceptual files (adjust this if your actual interface is different).
            var salesData = await _unitOfWork.BookedEventRepository.GetQueryable()
                .Where(bt => categoryIds.Contains(bt.TicketCategoryId))
                .GroupBy(bt => bt.TicketCategoryId)
                .Select(g => new
                {
                    TicketCategoryId = g.Key,
                    TotalQuantitySold = g.Sum(x => x.Quantity)
                })
                .ToDictionaryAsync(x => x.TicketCategoryId, x => x.TotalQuantitySold, cancellationToken);

            // 3. Map to DTO
            var dto = new EventDetailsDto
            {
                EventId = eventEntity.Id,
                Title = eventEntity.Title,
                Description = eventEntity.Description,
                Image = eventEntity.Image,
                EventDate = eventEntity.EventDate,
                EventTime = eventEntity.EventTime,
                VenueName = eventEntity.VenueName,
                VenueAddress = eventEntity.VenueAddress,
                PassTaxToCustomer = passTaxToCustomer,
                TotalCategoriesCount = eventEntity.TicketCategories.Count,
            };

            dto.TicketCategories = eventEntity.TicketCategories
                .Select(tc =>
                {
                    // Calculate final price based on the PassTaxToCustomer policy and global TaxRate
                    decimal finalPrice = passTaxToCustomer
                        ? tc.Price * (1 + applicableTaxRate)
                        : tc.Price;

                    return new TicketCategoryDetailsDto
                    {
                        Id = tc.Id,
                        Name = tc.Name,
                        Price = tc.Price,
                        TaxRate = applicableTaxRate, // Using the retrieved rate
                        FinalPricePerTicket = finalPrice,
                        Capacity = tc.Capacity,
                        TicketsSold = salesData.GetValueOrDefault(tc.Id, 0) // Use 0 if no sales data found
                    };
                })
                .OrderBy(c => c.Price)
                .ToList();

            return await Result<EventDetailsDto>.SuccessAsync(dto, "Fetched successfully");
        }
    }
    
}

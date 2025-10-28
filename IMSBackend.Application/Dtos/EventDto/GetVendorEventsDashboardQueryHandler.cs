using IMSBackend.Application.Contracts;
using IMSBackend.Application.Features.EventFeatures.Querries;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace IMSBackend.Application.Dtos.EventDto
{
    public class GetVendorEventsDashboardQueryHandler : IRequestHandler<GetVendorEventsDashboardQuery, Result<IEnumerable<EventDashboardItemDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserContext _userContext;

        public GetVendorEventsDashboardQueryHandler(IUnitOfWork unitOfWork, IUserContext userContext)
        {
            _unitOfWork = unitOfWork;
            _userContext = userContext;
        }
        public async Task<Result<IEnumerable<EventDashboardItemDto>>> Handle(GetVendorEventsDashboardQuery request, CancellationToken cancellationToken)
        {
            //fetch vendor details from the context
            var vendor = await _unitOfWork.VendorsRepository.GetSingleByExpression(x => x.AccountId == _userContext.UserId, cancellationToken);
            // 1. Get Base Events
            var eventsQuery = _unitOfWork.EventRepository.GetQueryable().Include(e => e.TicketCategories).Where(e => e.VendorId == vendor.Id).AsNoTracking();

            var events = await eventsQuery.ToListAsync(cancellationToken);

            if (!events.Any())
            {
                return null;
            }

            var eventIds = events.Select(e => e.Id).ToList();
            var allCategoryIds = events.SelectMany(e => e.TicketCategories).Select(tc => tc.Id).ToList();

            // 2. Aggregate Sales Data (Tickets Sold and Revenue)
            // We aggregate sales data from the BookedTicket entity for all relevant categories.
            var salesData = await _unitOfWork.BookedEventRepository.GetQueryable()
                .Where(bt => allCategoryIds.Contains(bt.TicketCategoryId))
                .GroupBy(bt => bt.TicketCategoryId)
                .Select(g => new
                {
                    TicketCategoryId = g.Key,
                    TotalQuantitySold = g.Sum(x => x.Quantity),
                    TotalRevenue = g.Sum(x => x.Quantity * x.UnitPrice) // Revenue = Quantity * UnitPrice
                })
                .ToListAsync(cancellationToken);

            // Map CategoryId to SalesData for quick lookup
            var salesLookup = salesData.ToDictionary(x => x.TicketCategoryId, x => x);

            // 3. Process Events and Map to DTO
            var dashboardItems = new List<EventDashboardItemDto>();

            foreach (var eventEntity in events)
            {
                // Calculate Total Capacity for the event (sum of all category capacities)
                int totalCapacity = eventEntity.TicketCategories.Sum(tc => tc.Capacity);

                // Calculate Aggregated Sales Metrics
                int eventTicketsSold = 0;
                decimal eventRevenue = 0;

                foreach (var category in eventEntity.TicketCategories)
                {
                    if (salesLookup.TryGetValue(category.Id, out var sales))
                    {
                        eventTicketsSold += sales.TotalQuantitySold;
                        eventRevenue += sales.TotalRevenue;
                    }
                }

                // Calculate final percentage and status
                decimal capacityPercentage = totalCapacity > 0 ? (decimal)eventTicketsSold / totalCapacity * 100 : 0;
                string status = eventEntity.EventDate >= DateTime.Today ? "Active" : "Completed";

                dashboardItems.Add(new EventDashboardItemDto
                {
                    EventId = eventEntity.Id,
                    Title = eventEntity.Title,
                    EventDate = eventEntity.EventDate,
                    Status = status,
                    TicketsSold = eventTicketsSold,
                    TotalCapacity = totalCapacity,
                    Revenue = eventRevenue,
                    CapacityPercentage = capacityPercentage,

                    // Note: 'Views' is set to a static placeholder as the source wasn't provided.
                    Views = 1234,
                    RevenueFormatted = FormatCurrency(eventRevenue)
                });
            }

            // Order by date, newest first (or whatever the UI requires)
            var orderedItems = dashboardItems.OrderByDescending(i => i.EventDate).ToList();

            return await Result<IEnumerable<EventDashboardItemDto>>.SuccessAsync(orderedItems);
        }

     



        private string FormatCurrency(decimal amount)
        {
            // Assuming Nigerian Naira (₦) for formatting as per the screenshot
            if (amount >= 1_000_000)
            {
                return $"₦{(amount / 1_000_000).ToString("F2", CultureInfo.InvariantCulture)}M";
            }
            if (amount >= 1_000)
            {
                return $"₦{(amount / 1_000).ToString("F2", CultureInfo.InvariantCulture)}K";
            }
            return $"₦{amount.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.EventDto
{
    public class EventDashboardItemDto
    {
        public Guid EventId { get; set; }
        public string Title { get; set; }
        public DateTime EventDate { get; set; }
        public string Status { get; set; } // e.g., "Active"

        // Metrics displayed on the dashboard
        public int TicketsSold { get; set; }
        public int TotalCapacity { get; set; }
        public string TicketsSoldSummary => $"{TicketsSold} / {TotalCapacity}"; // e.g., "342 / 500"

        public decimal Revenue { get; set; } // Aggregate revenue from BookedTickets
        public string RevenueFormatted { get; set; } // e.g., "₦5.13M" - requires formatting logic

        public int Views { get; set; } // Needs to come from a separate tracking service/field

        public decimal CapacityPercentage { get; set; } // Calculated based on TicketsSold / TotalCapacity
        public string CapacityPercentageFormatted => $"{CapacityPercentage:N0}%"; // e.g., "68%"
    }
}

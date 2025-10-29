using IMSBackend.Application.Contracts;
using IMSBackend.Common;
using IMSBackend.Domain.Entities.EventDomain;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.EventFeatures.Command.Update
{
    public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserContext _userContext;

        public UpdateEventCommandHandler(IUnitOfWork unitOfWork, IUserContext userContext)
        {
            _unitOfWork = unitOfWork;
            _userContext = userContext;
        }
        public async Task<Result<string>> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            var VendorId =await _unitOfWork.VendorsRepository.FindBySingleOrDefaultAsync(x => x.AccountId == _userContext.UserId, cancellationToken);
            if (VendorId == null) 
            {
                return await Result<string>.FailureAsync("No vendor found for this events");
            }
            // 1. Fetch the existing Event and its categories for tracking
            var eventEntity = await _unitOfWork.EventRepository.GetQueryable()
                .Include(e => e.TicketCategories)
                .FirstOrDefaultAsync(e => e.Id == request.EventId && e.VendorId ==VendorId.Id, cancellationToken);

            if (eventEntity == null)
            {
                return await Result<string>.FailureAsync("Event not found.");
            }

            // 2. Perform Ownership Check (Crucial Security Step)
            if (eventEntity.VendorId != VendorId.Id)
            {
                return await Result<string>.FailureAsync("Unauthorized: Event does not belong to this vendor.");
            }

            // 3. Update core Event details
            eventEntity.VenueName = request.VenueName;
            eventEntity.VenueAddress = request.VenueAddress;
            eventEntity.DateUpdated = DateTime.UtcNow;
            // eventEntity.UpdatedBy = request.UserId; // Assuming UpdatedBy is set by a base entity/middleware

            // 4. Manage Ticket Categories
            var existingCategoryIds = eventEntity.TicketCategories.Select(tc => tc.Id).ToHashSet();
            var commandCategoryIds = request.TicketCategories
                .Where(c => c.Id.HasValue)
                .Select(c => c.Id.Value)
                .ToHashSet();

            // 4.1 Handle Deletions (Categories present in DB but missing in Command)
            var categoriesToDelete = eventEntity.TicketCategories
                .Where(tc => !commandCategoryIds.Contains(tc.Id))
                .ToList();

            foreach (var category in categoriesToDelete)
            {
                // IMPORTANT: Before deletion, check if tickets have been sold. 
                // This is a safety check to prevent deleting categories with active sales.
                var ticketsSold = await _unitOfWork.BookedEventRepository.GetQueryable()
                    .CountAsync(bt => bt.TicketCategoryId == category.Id, cancellationToken);

                if (ticketsSold > 0)
                {
                    // Instead of failing the entire command, you might choose to soft-delete
                    // or just skip deletion and return a warning/error message.
                    return await Result<string>.FailureAsync($"Cannot delete category '{category.Name}'. {ticketsSold} tickets have been sold.");
                }

                await _unitOfWork.TicketCategoryRepository.Delete(category);
            }

            // 4.2 Handle Updates and Additions
            foreach (var categoryDto in request.TicketCategories)
            {
                if (categoryDto.Id.HasValue && existingCategoryIds.Contains(categoryDto.Id.Value))
                {
                    // Update existing category
                    var categoryToUpdate = eventEntity.TicketCategories
                        .First(tc => tc.Id == categoryDto.Id.Value);

                    // Capacity check: Cannot reduce capacity below already sold tickets
                    var ticketsSold = await _unitOfWork.BookedEventRepository.GetQueryable()
                        .Where(bt => bt.TicketCategoryId == categoryToUpdate.Id)
                        .SumAsync(bt => bt.Quantity, cancellationToken);

                    if (categoryDto.Capacity < ticketsSold)
                    {
                        return await Result<string>.FailureAsync($"Cannot reduce capacity for '{categoryDto.Name}' to {categoryDto.Capacity}. {ticketsSold} tickets are already sold.");
                    }

                    categoryToUpdate.Name = categoryDto.Name;
                    categoryToUpdate.Price = categoryDto.Price;
                    categoryToUpdate.Capacity = categoryDto.Capacity;
                    categoryToUpdate.DateUpdated = DateTime.UtcNow;
                   await _unitOfWork.TicketCategoryRepository.Update(categoryToUpdate);
                }
                else
                {
                    // Add new category
                    var newCategory = new TicketCategory
                    {
                        Id = Guid.NewGuid(),
                        EventId = request.EventId,
                        Name = categoryDto.Name,
                        Price = categoryDto.Price,
                        Capacity = categoryDto.Capacity,
                        DateCreated = DateTime.UtcNow,
                        // CreatedBy, etc.
                    };
                    await _unitOfWork.TicketCategoryRepository.AddAsync(newCategory);
                }
            }

            // 5. Save all changes
           await _unitOfWork.EventRepository.Update(eventEntity);
            await _unitOfWork.Save(cancellationToken);

            return await Result<string>.SuccessAsync($"Event and categories updated successfully.{eventEntity.Id}");
        }
    }
}

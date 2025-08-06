using IMSBackend.Application.Dtos.Admin;
using IMSBackend.Common.Models;
using IMSBackend.Common;

namespace IMSBackend.Application.Contracts;

public interface IAdminManagementService
{
    Task<Result<string>> DeleteAdminAsync(DeleteUser updateUser, CancellationToken cancellationToken);
    Task<PaginatedResult<AdminManagementDto>> GetAllAdminAsync(SearchPaginationFilter filter, CancellationToken cancellationToken);
    Task<Result<AdminManagementDto>> GetAdminAsync(Guid Id, CancellationToken cancellationToken);
    Task<Result<string>> UpdateAdminStatus(UpdateUserRequest updateUser, CancellationToken cancellationToken);
    Task<Result<string>> SuspendAdminAsync(SuspendUser updateUser, CancellationToken cancellationToken);
    Task<Result<string>> ActivateAdminAsync(ActivateUser updateUser, CancellationToken cancellationToken);
    Task<Result<string>> InvitationRequestWithRoleAsync(InvitationRequestWithRole invitationRequest, CancellationToken cancellationToken);
    Task<Result<AdminLoginResponseDto>> LoginAsync(AdminLoginRequest request, CancellationToken cancellationToken);
   
}

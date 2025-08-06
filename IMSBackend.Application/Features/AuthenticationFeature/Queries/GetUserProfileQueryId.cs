using IMSBackend.Application.Dtos.Auth.Responses;
using IMSBackend.Application.Contracts;
using IMSBackend.Common;
using MediatR;
using IMSBackend.Domain.Shared;
using AutoMapper;

namespace IMSBackend.Application.Features.AuthenticationFeature.Queries;

public class GetUserProfileQueryId : IRequest<Result<UserProfileDto>>
{
}

internal class GetUserProfileQueryIdHandler : IRequestHandler<GetUserProfileQueryId, Result<UserProfileDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IUserContext _userContext;
    public GetUserProfileQueryIdHandler(IUnitOfWork unitOfWork, IMapper mapper, IUserContext userContext)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userContext = userContext;
    }

    public async Task<Result<UserProfileDto>> Handle(GetUserProfileQueryId query, CancellationToken cancellationToken)
    {
        UserProfileDto userProfileDto = new UserProfileDto();
        var userProfile = await _unitOfWork.AccountRepository.GetByIdAsync(_userContext.UserId, cancellationToken);
        if (userProfile is null)
        {
            return await Result<UserProfileDto>.FailureAsync(new UserProfileDto(), "User not found");
        }

        return await Result<UserProfileDto>.SuccessAsync(userProfileDto, "User profile fetch successfully");
    }
}

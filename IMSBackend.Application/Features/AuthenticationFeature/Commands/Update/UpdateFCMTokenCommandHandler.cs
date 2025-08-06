using IMSBackend.Application.Contracts;
using MediatR;
using AutoMapper;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;

namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Update;
internal sealed class UpdateFCMTokenCommandHandler : IRequestHandler<UpdateFCMTokenCommand, Result<string>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IUserContext _userContext;
    private readonly IMediator _mediator;
    public UpdateFCMTokenCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IUserContext userContext, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userContext = userContext;
        _mediator = mediator;
    }

    public async Task<Result<string>> Handle(UpdateFCMTokenCommand command, CancellationToken cancellationToken)
    {
        var authInfo = await _unitOfWork.AccountRepository.GetByIdAsync(_userContext.UserId, cancellationToken);
        if (authInfo is null)
        {
            return await Result<string>.FailureAsync("User profile doesn't exist");
        }

        await _unitOfWork.AccountRepository.Update(authInfo);
        await _unitOfWork.Save(cancellationToken);

        return await Result<string>.SuccessAsync("Fcm token updated successfully");
    }
}

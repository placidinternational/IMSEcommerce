using IMSBackend.Application.Contracts;
using MediatR;
using AutoMapper;
using IMSBackend.Common;
using IMSBackend.Domain.Entities.Account;
using IMSBackend.Domain.Shared;

namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Delete;
internal sealed class DeleteAccountRequestCommandHandler : IRequestHandler<DeleteAccountRequestCommand, Result<Guid>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserContext _userContext;
    private readonly IMapper _mapper;

    public DeleteAccountRequestCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IUserContext userContext)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userContext = userContext;
    }

    public async Task<Result<Guid>> Handle(DeleteAccountRequestCommand command, CancellationToken cancellationToken)
    {
        Account post = await _unitOfWork.AccountRepository.GetByIdAsync(_userContext.UserId, cancellationToken);
        if (post != null)
        {
            post.IsDeleted = true;
            post.DateUpdated = DateTime.UtcNow;
            await _unitOfWork.AccountRepository.Update(post);
            await _unitOfWork.Save(cancellationToken);

            return await Result<Guid>.SuccessAsync(post.Id, "Customer account successfully deleted");
        }
        else
        {
            return await Result<Guid>.FailureAsync("Customer account doesn't exist");
        }
    }
}

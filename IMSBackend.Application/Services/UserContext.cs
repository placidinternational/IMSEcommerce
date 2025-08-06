using IMSBackend.Application.Contracts;
using IMSBackend.Application.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Services;
public sealed class UserContext(IHttpContextAccessor httpContextAccessor) : IUserContext
{
    public Guid UserId =>
        httpContextAccessor
            .HttpContext?
            .User
            .GetUserId() ??
        throw new ApplicationException("User context is unavailable");

    public bool IsAuthenticated =>
        httpContextAccessor
            .HttpContext?
            .User
            .Identity?
            .IsAuthenticated ??
        throw new ApplicationException("User context is unavailable");

    public string FullName =>
         httpContextAccessor
            .HttpContext?
            .User
            .GetFullName() ??
        throw new ApplicationException("User context is unavailable");

    public string Role =>
         httpContextAccessor
            .HttpContext?
            .User
            .GetRoleName() ??
        throw new ApplicationException("User context is unavailable");
}


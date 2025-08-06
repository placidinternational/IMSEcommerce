using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IMSBackend.Application.Contracts;
using IMSBackend.Application.Dtos.Auth.Requests;
using IMSBackend.Application.Dtos.Auth.Responses;
using IMSBackend.Application.Dtos.Auth;
using IMSBackend.Application.Validator;
using IMSBackend.Common;
using System.ComponentModel.DataAnnotations;
using IMSBackend.Application.Features.AuthenticationFeature.Queries;
using IMSBackend.Application.Features.AuthenticationFeature.Commands.Create;
using IMSBackend.Application.Features.AuthenticationFeature.Commands.Update;
using IMSBackend.Application.Features.AwardFeatures.Command;

namespace IMSBackend.BackendAPI.Controllers;

public class AccountController : BaseController
{
    private readonly ILogger<AccountController> _logger;
    private readonly IUserService _userService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger"></param>
    public AccountController(ILogger<AccountController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }


    /// <summary>
    /// This is the endpoint to authenticate User
    /// </summary>
    /// <param name="requestModel"></param>
    /// <returns></returns>
    [AllowAnonymous]
    [HttpPost]
    [Route("AuthenticateUser")]
    [ProducesResponseType(typeof(Result<LoginResponseDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Login(ValidateLoginQuery query, CancellationToken cancellationToken)
    {
        var request = new ValidateLoginQuery(query.Email, query.Password, query.IP, query.Browser);

        var userResult = await Sender.Send(request);
        if (userResult.Succeeded == false)

            return BadRequest(userResult.Messages);
        else
            return Ok(userResult);
    }

    /// <summary>
    /// This is the endpoint for otp email verification
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [AllowAnonymous]
    [HttpPost]
    [Route("Validate/OtpCode")]
    [ProducesResponseType(typeof(Result<UserEmailResponseDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> ValidateOtpCode(UserEmailRequestModel model, [FromHeader, Required] string hashCode)
    {
        var userRequestValidator = new UserEmailRequestValidator();
        var result = userRequestValidator.Validate(model);

        if (result.IsValid)
        {
            var request = new ValidateOtpQuery(model.OtpCode, model.Email, hashCode);
            var userResult = await Sender.Send(request);
            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }
        var errorMessages = result.Errors.Select(x => new { Error = x.ErrorMessage }).ToList();
        return BadRequest(new { Errors = errorMessages });
    }



    /// <summary>
    /// This is the endpoint for resending otp email 
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [AllowAnonymous]
    [HttpPost]
    [Route("Resend/OtpCode")]
    [ProducesResponseType(typeof(Result<ResendOtpDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Resend(UserEmailResendequestModel model)
    {
        var request = new ResendOtpQuery(model.Email);
        var userResult = await Sender.Send(request);
        if (userResult.Succeeded == false)
            return BadRequest(userResult);
        else
            return Ok(userResult);
    }

    /// <summary>
    /// This is the endpoint to create user account 
    /// </summary>
    /// <param name="requestModel"></param>
    /// <returns></returns>
    [AllowAnonymous]
    [HttpPost]
    [Route("Register")]
    [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Register(CreateAuthCommand requestModel)
    {
        var userResult = await Sender.Send(requestModel);

        if (userResult.Succeeded == false)
            return BadRequest(userResult);
        else
            return Ok(userResult);
    }


    /// <summary>
    /// This is the endpoint for forgot password
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [AllowAnonymous]
    [HttpPost]
    [Route("ForgotPassword")]
    [ProducesResponseType(typeof(Result<ForgotPasswordResponsetDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> ForgotPassword(ForgotPasswordDto model)
    {
        var userRequestValidator = new ForgotPasswordValidator();
        var result = userRequestValidator.Validate(model);
        if (result.IsValid)
        {
            var request = new UserForgotPasswordCommand()
            {
                EmailAddress = model.Email,
            };
            var userResult = await Sender.Send(request);
            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }
        var errorMessages = result.Errors.Select(x => x.ErrorMessage).ToList();
        string combinedString = string.Join(",", errorMessages.ToArray());
        return BadRequest(combinedString);
    }

    /// <summary>
    /// This is the endpoint for Create password
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [Authorize]
    [HttpPost]
    [Route("CreatePassword")]
    [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
    public async Task<IActionResult> CreatePassword(CreatePasswordDto model)
    {
        var request = new CreatePasswordCommand()
        {
            Password = model.Password,
        };
        var userResult = await Sender.Send(request);
        if (userResult.Succeeded == false)
            return BadRequest(userResult);
        else
            return Ok(userResult);
    }


    /// <summary>
    /// This is the endpoint for Reset password
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [AllowAnonymous]
    [HttpPost]
    [Route("ResetPassword")]
    [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
    public async Task<IActionResult> ResetPassword(ResetPasswordRequestDto model)
    {
        var userRequestValidator = new ResetPasswordRequestValidator();
        var result = userRequestValidator.Validate(model);
        if (result.IsValid)
        {
            var request = new ResetPasswordCommand()
            {
                EmailAddress = model.EmailAddress,
                NewPassword = model.NewPassword,
            };
            var userResult = await Sender.Send(request);
            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }
        var errorMessages = result.Errors.Select(x => x.ErrorMessage).ToList();
        string combinedString = string.Join(",", errorMessages.ToArray());
        return BadRequest(combinedString);
    }

    /// <summary>
    /// This is the endpoint for resending otp email 
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [AllowAnonymous]
    [HttpPost]
    [Route("Resend/ForgotPassword/OtpCode")]
    [ProducesResponseType(typeof(Result<ForgotPasswordResponsetDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> ResendForgotPasswordOtpCode(UserEmailResendequestModel model)
    {
        var request = new ResendForgotPasswordOtpQuery(model.Email);
        var userResult = await Sender.Send(request);
        if (userResult.Succeeded == false)
            return BadRequest(userResult);
        else
            return Ok(userResult);
    }

    /// <summary>
    /// This is the endpoint for validate Reset password otp
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [AllowAnonymous]
    [HttpPost]
    [Route("Reset/Password/ValidateOtp")]
    [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
    public async Task<IActionResult> ResetPasswordValidateOtp(ResetPasswordOtpRequestDto model, [FromHeader, Required] string hashCode)
    {
        var userRequestValidator = new ResetPasswordValidateOtpValidator();
        var result = userRequestValidator.Validate(model);
        if (result.IsValid)
        {
            var request = new ResetPasswordValidateOtpCommand()
            {
                EmailAddress = model.EmailAddress,
                HashCode = hashCode,
                OtpCode = model.OtpCode,
            };
            var userResult = await Sender.Send(request);
            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }
        var errorMessages = result.Errors.Select(x => x.ErrorMessage).ToList();
        string combinedString = string.Join(",", errorMessages.ToArray());
        return BadRequest(combinedString);
    }

    /// <summary>
    /// This is the endpoint for change password
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("ChangePassword")]
    [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
    public async Task<IActionResult> ChangePassword(ChangePasswordDto model)
    {
        var userRequestValidator = new ChangePasswordValidator();
        var result = userRequestValidator.Validate(model);
        if (result.IsValid)
        {
            var request = new UserChangePasswordCommand()
            {
                EmailAddress = model.EmailAddress,
                Password = model.NewPassword,
                OldPassword = model.OldPassword
            };

            var userResult = await Sender.Send(request);
            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }
        var errorMessages = result.Errors.Select(x => x.ErrorMessage).ToList();
        string combinedString = string.Join(",", errorMessages.ToArray());
        return BadRequest(combinedString);
    }

}

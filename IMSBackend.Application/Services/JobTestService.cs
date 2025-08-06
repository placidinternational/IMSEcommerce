using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using IMSBackend.Application.Contracts;
using IMSBackend.Application.Dtos.Admin;
using IMSBackend.Infrastructure.EmailService;
using IMSBackend.Infrastructure.Settings;

namespace IMSBackend.Application.Services;
public class JobTestService : IJobTestService
{
    private readonly IInfraUnitOfWork _infraUnitOfWork;
    private EmailConfig _emailConfig { get; }

    public JobTestService(IInfraUnitOfWork infraUnitOfWork, IOptions<EmailConfig> emailConfig, IWebHostEnvironment environment)
    {
        _infraUnitOfWork = infraUnitOfWork;
        _emailConfig = emailConfig.Value;
    }
    public async Task<string> SendOTPCode(string otpcode, string receiveremail)
    {
        try
        {
            var fiveMinutesLater = DateTime.UtcNow.AddMinutes(5);
            string emailBody = await EmailComposeBody.SendOTP(otpcode, receiveremail, fiveMinutesLater.ToString());

            string senderEmail = _emailConfig.EmailFrom;
            string senderDisplayName = _emailConfig.DisplayName;

            EmailMessage email = new EmailMessage()
            {
                Subject = "OTP Code",
                Message = emailBody,
                Receiver = receiveremail,
                Sender = _emailConfig.EmailFrom,
                UserName = _emailConfig.Username,
                DisplayName = senderDisplayName
            };

            await _infraUnitOfWork.emailServices.SendEmail(email);
            return "success";
        }
        catch (Exception ex)
        {
            return "success";
        }
    }

    public async Task<string> SendForgotPasswordEmailCode(string receiveremail, string otpcode)
    {
        try
        {
            string emailBody = await EmailComposeBody.PasswordReset(receiveremail, otpcode);

            string senderEmail = _emailConfig.EmailFrom;
            string senderDisplayName = _emailConfig.DisplayName;

            EmailMessage email = new EmailMessage()
            {
                Subject = "Password Reset",
                Message = emailBody,
                Receiver = receiveremail,
                Sender = senderEmail,
                DisplayName = senderDisplayName
            };

            await _infraUnitOfWork.emailServices.SendEmail(email);
            return "success";
        }
        catch (Exception ex)
        {
            return "success";
        }
    }

    public async Task<string> SendInvitationCodeAsync(InvitationEmailRequest emailRequest, CancellationToken cancellationToken)
    {
        try
        {

            string senderEmail = _emailConfig.EmailFrom;
            string senderDisplayName = _emailConfig.DisplayName;

            EmailMessage email = new EmailMessage()
            {
                Subject = emailRequest.Subject,
                Message = emailRequest.Body,
                Receiver = emailRequest.EmailAddress,
                Sender = senderEmail,
                DisplayName = senderDisplayName,
                UserName = _emailConfig.Username
            };

            await _infraUnitOfWork.emailServices.SendEmail(email);
            return "success";
        }
        catch (Exception ex)
        {
            return "failed";
        }
    }

    public async Task<string> SendWelcomeEmail(string emailAddress, string fullName, string phoneNumber,string nomineeid, string awardname)
    {
        try
        {
            string emailBody = await EmailComposeBody.Registration(emailAddress, fullName, phoneNumber, nomineeid,awardname);

            string senderEmail = _emailConfig.EmailFrom;
            string senderDisplayName = _emailConfig.DisplayName;

            EmailMessage email = new EmailMessage()
            {
                Subject = "Welcome Email",
                Message = emailBody,
                Receiver = emailAddress,
                Sender = senderEmail,
                DisplayName = senderDisplayName
            };

            await _infraUnitOfWork.emailServices.SendEmail(email);
            return "success";
        }
        catch (Exception ex)
        {
            return "success";
        }
    }


    public async Task<string> SendLogin(string Ip, string fullname, string browser, DateTime date, string emailaddress, CancellationToken cancellationToken)
    {
        try
        {
            string emailBody = await EmailComposeBody.Login(browser, fullname, Ip, date, emailaddress);
            string senderEmail = _emailConfig.EmailFrom;
            string senderDisplayName = _emailConfig.DisplayName;

            EmailMessage email = new EmailMessage()
            {
                Subject = "Login Activitites",
                Message = emailBody,
                Receiver = emailaddress,
                Sender = senderEmail,
                DisplayName = senderDisplayName,
                UserName = _emailConfig.Username
            };

            await _infraUnitOfWork.emailServices.SendEmail(email);
            return "success";
        }
        catch (Exception ex)
        {
            return "failed";
        }
    }

    public async Task<string> SendReceipt(InvitationEmailRequest emailRequest, CancellationToken cancellationToken)
    {
        try
        {

            string senderEmail = _emailConfig.EmailFrom;
            string senderDisplayName = _emailConfig.DisplayName;

            EmailMessage email = new EmailMessage()
            {
                Subject = emailRequest.Subject,
                Message = emailRequest.Body,
                Receiver = emailRequest.EmailAddress,
                Sender = senderEmail,
                DisplayName = senderDisplayName,
                UserName = _emailConfig.Username
            };

            await _infraUnitOfWork.emailServices.SendEmail(email);
            return "success";
        }
        catch (Exception ex)
        {
            return "failed";
        }
    }
}

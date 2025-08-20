using IMSBackend.Application.Dtos.Admin;

namespace IMSBackend.Application.Contracts;
public interface IJobTestService
{
    Task<string> SendOTPCode(string otpcode, string phone);
    Task<string> SendForgotPasswordEmailCode(string receiveremail, string otpcode);
    Task<string> SendInvitationCodeAsync(InvitationEmailRequest emailRequest, CancellationToken cancellationToken);
    Task<string> SendWelcomeEmail(string emailAddress, string fullName, string phoneNumber, string nomineeid, string awardname);
    Task<string> SendLogin(string Ip, string fullname, string browser, DateTime date, string emailaddress, CancellationToken cancellationToken);
    Task<string> SendReceipt(InvitationEmailRequest emailRequest, CancellationToken cancellationToken);
    Task<string> BusinessPitch(string emailAddress, string fullName, string amount, string eventname, string referencenumber);
    Task<string> CastVote(string emailAddress, string nomineename, string noofvotes, string category, string referencenumber);
    Task<string> NomineeCastVote(string fullname,string emailAddress, string totalnoofvotes, string totalPeopleVoted);
}

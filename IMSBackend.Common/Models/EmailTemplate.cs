namespace IMSBackend.Common.Models;

public class EmailTemplate
{
    public string? GlobalTemplateName { get; set; }
    public EmailTemplateIds? EmailTemplateIds { get; set; }
    public EmailTemplateField? Invitation { get; set; }
    public EmailTemplateField? NewUser { get; set; }
    public EmailTemplateField? Otp { get; set; }
}

public class EmailTemplateIds
{
    public string? OtpTemplate { get; set; }
    public string? ExchangeRateTemplate { get; set; }
    public string? NewRecipientTemplate { get; set; }
    public string? EmailUpdateTemplate { get; set; }
    public string? SupportTemplate { get; set; }
    public string? FailedTransactionTemplate { get; set; }
    public string? SuccessfulTransactionTemplate { get; set; }
    public string? PendingApprovalTemplate { get; set; }
    public string? WelcomeEmailTemplate { get; set; }
    public string? RewardPointsTemplate { get; set; }
    public string? LoginOtpTemplate { get; set; }
    public string? ResetPasswordOtpTemplate { get; set; }
    public string? AdminPasswordTemplate { get; set; }  
    public string? CompleteKYC {  get; set; }   
    public string? FollowUp {  get; set; }  
}

public class EmailTemplateField
{
    public string? Subject { get; set; }
    public string? Body { get; set; }
}
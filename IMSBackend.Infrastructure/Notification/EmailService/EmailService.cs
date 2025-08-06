using System.Net;
using System.Net.Mail;
using System.Text;
using Microsoft.Extensions.Options;
using MimeKit;
using IMSBackend.Infrastructure.Settings;
using SmtpClient = System.Net.Mail.SmtpClient;

namespace IMSBackend.Infrastructure.EmailService
{
    public interface IEmailService
    {
        (string, string) GetEmailSender();
        Task<bool> SendEmail(EmailMessage email);
    }


    public class EmailService : IEmailService
    {
        private EmailConfig emailConfig { get; }
        public EmailService(IOptions<EmailConfig> emailConfig)
        {
            this.emailConfig = emailConfig.Value;
        }

        private async Task SendEmailAsync(EmailMessage email)
        {
            try
            {
                string toEmail = email.Receiver?.Trim();

                if (string.IsNullOrWhiteSpace(toEmail) || !IsValidEmail(toEmail))
                    throw new Exception($"Invalid email address: {toEmail}");

                // Build MimeMessage (if you're using MimeKit elsewhere)
                var message = new MimeMessage();

                // Corrected: DisplayName first, then Email
                message.From.Add(new MailboxAddress(email.DisplayName, email.Sender));
                message.To.Add(new MailboxAddress("", toEmail)); // Empty name is fine
                message.Subject = email.Subject;
                message.Body = new TextPart("html") { Text = email.Message };

                // Build MailMessage for System.Net.Mail
                var mail = new MailMessage
                {
                    From = new MailAddress(email.Sender, email.DisplayName)
                };
                mail.To.Add(new MailAddress(toEmail));
                mail.Subject = email.Subject;
                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Body = email.Message;
                mail.Priority = MailPriority.High;

                using (var smtp = new SmtpClient(emailConfig.Host, emailConfig.Port))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(email.Sender, emailConfig.Password);
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Email sending failed: {ex.Message}", ex);
            }
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        public (string, string) GetEmailSender()
        {
            return (emailConfig.Username, emailConfig.DisplayName);
        }

        public async Task<bool> SendEmail(EmailMessage email)
        {
            await this.SendEmailAsync(email);
            return true;
        }
    }
}
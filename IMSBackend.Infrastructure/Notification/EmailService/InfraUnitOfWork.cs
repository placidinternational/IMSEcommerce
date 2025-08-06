using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using IMSBackend.Infrastructure.Settings;

namespace IMSBackend.Infrastructure.EmailService
{
    public interface IInfraUnitOfWork
    {
        IEmailService emailServices { get; }
    }

    public class InfraUnitOfWork : IInfraUnitOfWork
    {
        private readonly IOptions<EmailConfig> _emailConfig;
        private readonly IConfiguration _appconfig;
       

        public InfraUnitOfWork(IConfiguration config, IOptions<EmailConfig> emailConfig)
        {
            this._appconfig = config;
            this._emailConfig = emailConfig;
        }

        private IEmailService _emailService;
        public IEmailService emailServices
        {
            get
            {
                if (this._emailService == null)
                {
                    this._emailService = new EmailService(_emailConfig);
                }

                return _emailService;
            }
        }
    }
}

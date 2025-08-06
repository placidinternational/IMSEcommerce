using System.Collections.Generic;

namespace IMSBackend.Infrastructure.Settings
{
    public class EmailMessage
    {
        public string Message { get; set; }
        public string Subject { get; set; }
        public string Sender { get; set; }
        public string DisplayName { get; set; }
        public string Receiver { get; set; }
        public string FileUrl { get; set; }
        public string UserName { get; set; }
        public List<string> ReceiversList { get; set; }
    }
}
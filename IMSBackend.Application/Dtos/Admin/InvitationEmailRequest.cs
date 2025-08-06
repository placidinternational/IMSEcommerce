using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.Admin;
public class InvitationEmailRequest
{
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}

public class SendInvoiceEmailRequest
{
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    public string Subject { get; set; }
    public byte[] Body { get; set; }

}

public class EmailAttachment
{
    public byte[] Content { get; set; }
    public string FileName { get; set; }
    public string ContentType { get; set; }
}
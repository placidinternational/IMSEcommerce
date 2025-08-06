using System.ComponentModel.DataAnnotations;

namespace IMSBackend.Common.Models;

public class NotificationRequest
{
    [Required]
    public string Subject { get; set; }
    [Required]
    public string To { get; set; }
    public object Data { get; set; }
    public string Body { get; set; }
    public string Name { get; set; }
}

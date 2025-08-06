using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.Admin;
public class AdminManagementDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Role { get; set; }
    public string Status { get; set; }
    public DateTime? LastActiveDate { get; set; }
    public DateTime DateCreated { get; set; }
    public Guid RoleId { get; set; }
    public List<PermissionObject> Permissions { get; set; }
}

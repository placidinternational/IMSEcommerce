using IMSBackend.Common.Enums;

namespace IMSBackend.Application.Dtos.Admin;

public class UpdateUserRequest
{
    public Guid Id { get; set; }
    public StatusEnum Status { get; set; }
    public Guid UpdatedBy { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Guid RoleId { get; set; }
}


public class SuspendUser
{
    public Guid Id { get; set; }
}

public class DeleteUser : SuspendUser
{
    public string Reason { get; set; }
}

public class ActivateUser : SuspendUser
{

}
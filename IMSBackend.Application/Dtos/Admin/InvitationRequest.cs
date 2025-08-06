using IMSBackend.Common.Enums;

namespace IMSBackend.Application.Dtos.Admin;
public class InvitationRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public RoleObject Role { get; set; }
}

public class InvitationRequestWithRole
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public RoleObject Role { get; set; }
    public UserTypeEnum Usertype { get; set; }
}


public class RoleObject
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
public class PermissionObject
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}

public class PermissionActionObject
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
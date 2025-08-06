namespace IMSBackend.Application.Dtos.Auth
{
    public class ForgotPasswordDto
    {
        public string Email { get; set; }
    }

    public class ChangePasswordDto
    {
        public string EmailAddress { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }

    public class ResetPasswordRequestDto
    {
        public string EmailAddress { get; set; }
        public string NewPassword { get; set; }
    }

    public class ResetPasswordOtpRequestDto
    {
        public string OtpCode { get; set; }
        public string EmailAddress { get; set; }
    }

    public class CreatePasswordDto
    {
        public string Password { get; set; }
    }
}

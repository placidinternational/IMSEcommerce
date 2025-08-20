using System.Text.RegularExpressions;

namespace IMSBackend.Infrastructure.EmailService
{
    public static class EmailComposeBody
    {

        private static string registration_EmailTemplate;
        private static string login_Template;
        private static string contact_Template;
        private static string ForgotPassword_Template;
        private static string Resend_Template;
        private static string RegistrationAgent;
        private static string OTP_Template;
        private static string Business_Pitch;
        private static string Cast_Vote;
        private static string Nominee_Vote;
        static EmailComposeBody()
        {
            EmailComposeBody.registration_EmailTemplate = "./EmailTemplates/RegEmail.html";
            EmailComposeBody.ForgotPassword_Template = "./EmailTemplates/ForgotPswd.html";
            EmailComposeBody.Resend_Template = "./EmailTemplates/ResendOTP.html";
            EmailComposeBody.login_Template= "./EmailTemplates/login.html";
            EmailComposeBody.contact_Template = "./EmailTemplates/contact.html";
            EmailComposeBody.RegistrationAgent = "./EmailTemplates/registeragent.html";
            EmailComposeBody.OTP_Template = "./EmailTemplates/OTP.html";
            EmailComposeBody.Business_Pitch = "./EmailTemplates/BusinessPitch.html";
            EmailComposeBody.Cast_Vote = "./EmailTemplates/CastVote.html";
            EmailComposeBody.Nominee_Vote = "./EmailTemplates/NomineeCastVote.html";
        }

        // Completed 
        public static async Task<string> Registration(string email, string Fullname, string phone, string nomineeid, string awardname)
        {
            try
            {
                string HTMLBody = "";

                using (StreamReader sReader = System.IO.File.OpenText(EmailComposeBody.registration_EmailTemplate))
                {
                    HTMLBody = await sReader.ReadToEndAsync();
                    var placeHolders = new Dictionary<string, string>
                    {
                        {"${email}",email},
                        {"${fullname}", Fullname},
                        {"${phonenumber}", phone },
                        {"${nomineeid}", nomineeid },
                        {"${category}", awardname },
                        
                    };
                    string bodyy = ParseEmail(placeHolders, HTMLBody);

                    return bodyy;

                }
                
            }
            catch (Exception ex)
            {
                string mmm = ex.Message;
                return mmm;
            }
        }

        public static async Task<string> BusinessPitch(string email, string Fullname, string amount, string eventname, string referencenumber)
        {
            try
            {
                string HTMLBody = "";

                using (StreamReader sReader = System.IO.File.OpenText(EmailComposeBody.registration_EmailTemplate))
                {
                    HTMLBody = await sReader.ReadToEndAsync();
                    var placeHolders = new Dictionary<string, string>
                    {
                        {"${email}",email},
                        {"${fullname}", Fullname},
                        {"${amount}", amount },
                        {"${eventname}", eventname },
                        {"${referencenumber}", referencenumber },

                    };
                    string bodyy = ParseEmail(placeHolders, HTMLBody);

                    return bodyy;

                }

            }
            catch (Exception ex)
            {
                string mmm = ex.Message;
                return mmm;
            }
        }

        public static async Task<string> CastVote(string emailaddress, string nomineename, string noofvotes, string category, string referencenumber)
        {
            try
            {
                string HTMLBody = "";

                using (StreamReader sReader = System.IO.File.OpenText(EmailComposeBody.Cast_Vote))
                {
                    HTMLBody = await sReader.ReadToEndAsync();
                    var placeHolders = new Dictionary<string, string>
                    {
                        {"${email}",emailaddress},
                        {"${nomineename}", nomineename},
                        {"${noofvotes}", noofvotes },
                        {"${category}", category },
                        {"${referencenumber}", referencenumber },

                    };
                    string bodyy = ParseEmail(placeHolders, HTMLBody);

                    return bodyy;

                }

            }
            catch (Exception ex)
            {
                string mmm = ex.Message;
                return mmm;
            }
        }

        
             public static async Task<string> NomineeCastVote(string fullname,string emailaddress, string totalvotes, string totalPeopleVoted)
        {
            try
            {
                string HTMLBody = "";

                using (StreamReader sReader = System.IO.File.OpenText(EmailComposeBody.Nominee_Vote))
                {
                    HTMLBody = await sReader.ReadToEndAsync();
                    var placeHolders = new Dictionary<string, string>
                    {
                        {"${email}",emailaddress},
                        {"${fullname}",fullname},
                        {"${noofvotes}", totalvotes },
                        {"${totalpeoplevoted}", totalPeopleVoted },

                    };
                    string bodyy = ParseEmail(placeHolders, HTMLBody);

                    return bodyy;

                }

            }
            catch (Exception ex)
            {
                string mmm = ex.Message;
                return mmm;
            }
        }
        public static async Task<string> Login(string Browser, string Fullname, string Ip, DateTime Date, string emailaddress)
        {
            try
            {
                string HTMLBody = "";

                using (StreamReader sReader = System.IO.File.OpenText(EmailComposeBody.login_Template))
                {
                    HTMLBody = await sReader.ReadToEndAsync();
                    var placeHolders = new Dictionary<string, string>
                    {
                        {"${Browser}",Browser},
                        {"${Fullname}", Fullname},
                        {"${Ip}", Ip},
                        {"${Date}", Date.ToString()},
                    };
                    string bodyy = ParseEmail(placeHolders, HTMLBody);

                    return bodyy;

                }
                //var emailBody = string.Format(HTMLBody, fullName, user.email, password, pin, refCode, resetCode);
                //return emailBody;
            }
            catch (Exception ex)
            {
                string mmm = ex.Message;
                return mmm;
            }
        }

        public static async Task<string> SendOTP(string code, string email, string date)
        {
            /*
           * 0 - Name,1 - email , 2 - password, 3- Pin , 4 - referralCode , 5- resetCode, 6-iosLink , 7 - androidLink
           */
            try
            {
                //string fullName = string.Concat(user., " ", user.lastName);
                string HTMLBody = "";

                using (StreamReader sReader = System.IO.File.OpenText(EmailComposeBody.OTP_Template))
                {
                    HTMLBody = await sReader.ReadToEndAsync();

                    var placeHolders = new Dictionary<string, string>
                {

                    {"${email}", email},
                    {"${OtpCode}", code},
                     {"${expirytime}", date}
                };
                    string bodyy = ParseEmail(placeHolders, HTMLBody);

                    return bodyy;

                }
                //var emailBody = string.Format(HTMLBody, fullName, user.email, password, pin, refCode, resetCode);
                //return emailBody;
            }
            catch (Exception ex)
            {
                string mmm = ex.Message;
                return mmm;
            }
        }

        public static async Task<string> PasswordReset(string email, string code)
        {
            /*
             * 0 - Name,1 - email , 2 - password, 3- Pin , 4 - referralCode , 5- resetCode, 6-iosLink , 7 - androidLink
             */
            try
            {
                //string fullName = string.Concat(user., " ", user.lastName);
                string HTMLBody = "";

                using (StreamReader sReader = System.IO.File.OpenText(EmailComposeBody.ForgotPassword_Template))
                {
                    HTMLBody = await sReader.ReadToEndAsync();

                    var placeHolders = new Dictionary<string, string>
                    {

                        {"${email}", email},
                        {"${password}", code}
                    };
                    string bodyy = ParseEmail(placeHolders, HTMLBody);

                    return bodyy;

                }
                //var emailBody = string.Format(HTMLBody, fullName, user.email, password, pin, refCode, resetCode);
                //return emailBody;
            }
            catch (Exception ex)
            {
                string mmm = ex.Message;
                return mmm;
            }
        }

        public static async Task<string> ResendOTP(string email, string otpCode)
        {
            /*
             * 0 - Name,1 - email , 2 - password, 3- Pin , 4 - referralCode , 5- resetCode, 6-iosLink , 7 - androidLink
             */
            try
            {
                //string fullName = string.Concat(user., " ", user.lastName);
                string HTMLBody = "";

                using (StreamReader sReader = System.IO.File.OpenText(EmailComposeBody.Resend_Template))
                {
                    HTMLBody = await sReader.ReadToEndAsync();

                    var placeHolders = new Dictionary<string, string>
                    {

                        {"${email}", email},
                        {"${OtpCode}", otpCode}
                    };
                    string bodyy = ParseEmail(placeHolders, HTMLBody);

                    return bodyy;

                }
                //var emailBody = string.Format(HTMLBody, fullName, user.email, password, pin, refCode, resetCode);
                //return emailBody;
            }
            catch (Exception ex)
            {
                string mmm = ex.Message;
                return mmm;
            }
        }
        public static async Task<string> Login1(string fullName, string agentNumber, CancellationToken cancellationToken)
        {
            try
            {
                string HTMLBody = "";

                using (StreamReader sReader = System.IO.File.OpenText(EmailComposeBody.login_Template))
                {
                    HTMLBody = await sReader.ReadToEndAsync();
                    var placeHolders = new Dictionary<string, string>
                    {
                        {"${Fullname}", fullName},
                        {"${Agent}", agentNumber},
                    };
                    string bodyy = ParseEmail(placeHolders, HTMLBody);

                    return bodyy;

                }
                //var emailBody = string.Format(HTMLBody, fullName, user.email, password, pin, refCode, resetCode);
                //return emailBody;
            }
            catch (Exception ex)
            {
                string mmm = ex.Message;
                return mmm;
            }
        }

        public static async Task<string> ContactMessage(string message, string email, string name, string phonenumber, string subject)
        {
            /*
             * 0 - Name,1 - email , 2 - password, 3- Pin , 4 - referralCode , 5- resetCode, 6-iosLink , 7 - androidLink
             */
            string fullName = string.Concat(name);
            string HTMLBody = "";

            using (StreamReader sReader = System.IO.File.OpenText(EmailComposeBody.contact_Template))
            {
                HTMLBody = await sReader.ReadToEndAsync();
                object[] myData =
                {
                    fullName,email,message,phonenumber,subject
                };
                var emailBody = string.Format(HTMLBody, myData);
                return emailBody;
            }

        }

        private static string ParseEmail(Dictionary<string, string> placeHolders, string body)
        {
            return placeHolders.Keys.Where(key => Regex.IsMatch(key, @"\${[^""]+}")).Aggregate(body, (current, key) => current.Replace(key, placeHolders[key]));
        }

    }

}
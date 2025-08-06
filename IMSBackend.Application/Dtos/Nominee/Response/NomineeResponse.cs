using IMSBackend.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.Nominee.Response
{
    public class NomineeResponse
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public UserTypeEnum? UserType { get; set; }
        public StatusEnum Status { get; set; }
        public string CompanyName { get; set; }
        public string? Logo { get; set; }
        public string? Picture { get; set; }
        public string? Biography { get; set; }
        public string Category { get; set; }
        public string NomineeCode { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

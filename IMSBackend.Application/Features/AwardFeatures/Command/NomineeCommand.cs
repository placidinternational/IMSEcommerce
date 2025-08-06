using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.Award;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Command
{
    public class NomineeCommand : IRequest<Result<string>>
    {
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public string Picture { get; set; }
        public string Biography { get; set; }
        public string Password { get; set; }
        public Guid CategoryId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
    }
}

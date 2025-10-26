using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.VendorFeatures.Command.Create
{
    public class BankDetailsCommand : IRequest<Result<string>>
    {
        public Guid VendorId { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
    }
}

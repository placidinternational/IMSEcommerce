using IMSBackend.Application.Dtos.Auth;
using IMSBackend.Application.Features.AuthenticationFeature.Queries;
using IMSBackend.Application.Features.VendorFeatures.Command.Create;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMSBackend.API.Controllers
{
    public class VendorController : BaseController
    {


        // <summary>
        /// This is the endpoint to onboard vednors
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
       
        [HttpPost]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> companydetails(VendorCommand query, CancellationToken cancellationToken)
        {

            var userResult = await Sender.Send(query);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }

        // <summary>
        /// This is the endpoint to register bank details for vendors
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("bankdetails")]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> bankdetails(BankDetailsCommand query, CancellationToken cancellationToken)
        {

            var userResult = await Sender.Send(query);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }
    }
}

using IMSBackend.Application.Features.CheckoutFeatures;
using IMSBackend.Application.Features.CustomerFeatures;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using IMSBackend.Common.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMSBackend.API.Controllers
{
    public class CustomerController : BaseController
    {
        // <summary>
        /// This is the endpoint to checkout products 
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpPost]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> ProductOrder(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var userResult = await Sender.Send(request);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }
    }
}

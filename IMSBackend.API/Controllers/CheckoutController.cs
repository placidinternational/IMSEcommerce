using CloudinaryDotNet.Actions;
using IMSBackend.Application.Dtos.OrderDto;
using IMSBackend.Application.Features.CheckoutFeatures;
using IMSBackend.Application.Features.ProductFeatures.Command.Create;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using IMSBackend.Common.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace IMSBackend.API.Controllers
{

    public class CheckoutController : BaseController
    {

        // <summary>
        /// This is the endpoint to checkout products 
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpPost("ProductCheckout")]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> ProductOrder([FromBody] ProcessProductOrderCommand request, CancellationToken cancellationToken)
        {
            var userResult = await Sender.Send(request);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }

        [HttpPost("EventCheckout")]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> EventOrder([FromBody] ProcessEventOrderCommand request, CancellationToken cancellationToken)
        {
            var userResult = await Sender.Send(request);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }
    }
}

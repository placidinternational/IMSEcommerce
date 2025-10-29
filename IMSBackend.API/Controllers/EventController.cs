using IMSBackend.Application.Dtos.EventDto;
using IMSBackend.Application.Features.EventFeatures.Command.Create;
using IMSBackend.Application.Features.EventFeatures.Querries;
using IMSBackend.Application.Features.ProductFeatures.Command.Create;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMSBackend.API.Controllers
{
    public class EventController : BaseController
    {
        // <summary>
        /// This is the endpoint to create events 
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpPost]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create(EventCommand query, CancellationToken cancellationToken)
        {

            var userResult = await Sender.Send(query);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }

        // <summary>
        /// This is the endpoint to create events 
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpGet("GetEventByVendor")]
        [ProducesResponseType(typeof(Result<VendorEventsDashboardDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetEvents()
        {
            var query = new GetVendorEventsDashboardQuery { };
            var userResult = await Sender.Send(query);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }

        // <summary>
        /// This is the endpoint to create events 
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpGet("GetEventDetailsById")]
        [ProducesResponseType(typeof(Result<EventDetailsDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetEventDetails([FromQuery] Guid eventId)
        {
            var query = new GetEventDetailsQuery { EventId = eventId};
            var userResult = await Sender.Send(query);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }
    }
}

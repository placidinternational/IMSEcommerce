using IMSBackend.Application.Dtos.BusinessPitchDto;
using IMSBackend.Application.Features.AwardFeatures.Command.Categories;
using IMSBackend.Application.Features.AwardFeatures.Command.Voting;
using IMSBackend.Application.Features.BusinessPitchFeatures.Command;
using IMSBackend.Application.Features.BusinessPitchFeatures.Querries;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMSBackend.API.Controllers
{
   
    public class BusinessPitchController : BaseController
    {
        /// <summary>
        /// This is the endpoint to create business pitch
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Register(BusinessPitchCommand requestModel)
        {
            var userResult = await Sender.Send(requestModel);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This is the endpoint to get pitch price
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(Result<PitchPriceDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> PitchPrice()
        {
            var result = new GetPitchPriceQuery
            {

            };
            var userResult = await Sender.Send(result);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This is the endpoint to create business pitch
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpPost("ExibitionStand")]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> ExibitionStand(ExibitionStandCommand requestModel)
        {
            var userResult = await Sender.Send(requestModel);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This is the endpoint to create Dinner Ticket
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpPost("DinnerTicket")]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> DinnerTicket(DinnerTicketCommand requestModel)
        {
            var userResult = await Sender.Send(requestModel);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This is the endpoint to get pitch price
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpGet("GetAllExibitionStand")]
        [ProducesResponseType(typeof(Result<ExibitionStandResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllExibitionStand()
        {
            var result = new GetAllExibitionStandQuery
            {

            };
            var userResult = await Sender.Send(result);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }
    }
}

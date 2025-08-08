using IMSBackend.Application.Dtos.BusinessPitchDto;
using IMSBackend.Application.Features.AwardFeatures.Command.Categories;
using IMSBackend.Application.Features.AwardFeatures.Command.Voting;
using IMSBackend.Application.Features.BusinessPitchFeatures.Command;
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
    }
}

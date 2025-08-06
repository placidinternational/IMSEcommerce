using IMSBackend.Application.Dtos.Auth.Requests;
using IMSBackend.Application.Dtos.Auth.Responses;
using IMSBackend.Application.Features.AuthenticationFeature.Queries;
using IMSBackend.Application.Features.AwardFeatures.Command.Nominees;
using IMSBackend.Application.Features.AwardFeatures.Command.Voting;
using IMSBackend.Application.Validator;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IMSBackend.API.Controllers
{

    public class CastVoteController : BaseController
    {


        /// <summary>
        /// This is the endpoint to cast vote
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> CastVote(CastVoteCommand requestModel)
        {
            var userResult = await Sender.Send(requestModel);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }
    }
}

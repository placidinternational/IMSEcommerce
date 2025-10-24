using IMSBackend.Application.Dtos.Auth.Requests;
using IMSBackend.Application.Dtos.Auth.Responses;
using IMSBackend.Application.Dtos.NewFolder;
using IMSBackend.Application.Dtos.Nominee.Response;
using IMSBackend.Application.Dtos.VotingDto;
using IMSBackend.Application.Features.AuthenticationFeature.Queries;
using IMSBackend.Application.Features.AwardFeatures.Command.Nominees;
using IMSBackend.Application.Features.AwardFeatures.Command.Voting;
using IMSBackend.Application.Features.AwardFeatures.Querries.NomineesQuerries;
using IMSBackend.Application.Features.AwardFeatures.Querries.VotingQuerries;
using IMSBackend.Application.Validator;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Twilio.Rest.Messaging.V1.Service;

namespace IMSBackend.API.Controllers
{

    [Authorize]
    public class CastVoteController : BaseController
    {

        /// <summary>
        /// This is the endpoint to cast vote
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [AllowAnonymous]
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


        /// <summary>
        /// This is the endpoint to cast  manual vote
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost("ManualVote")]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> ManualVote(ManualVoteCommand requestModel)
        {
            var userResult = await Sender.Send(requestModel);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }


        /// <summary>
        /// This is the endpoint to get all votes
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpGet]
        [ProducesResponseType(typeof(Result<VotingResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string? search = null, string? category = null)
        {
            var query = new GetAllVotesQuery
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                SearchParam = search,
                Category = category
            };

            var userResult = await Sender.Send(query);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This is the endpoint to get votes nomineeId
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpGet("GetByNomineeId")]
        [ProducesResponseType(typeof(Result<VotingResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetByNomineeId([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string? search = null, string? category = null)
        {
            var query = new GetVoteByNomineeQuery
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                SearchParam = search,
                Category = category
            };
            var userResult = await Sender.Send(query);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This is the endpoint to get votes nomineeId
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpGet("GetVoteById")]
        [ProducesResponseType(typeof(Result<VotingResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetVoteById([FromQuery] Guid Id)
        {
            var query = new GetVoteByNomineeQuery
            {
               
            };
            var userResult = await Sender.Send(query);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This is the endpoint to get vote count by nomineeId
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("countbynomineeId")]
        [ProducesResponseType(typeof(Result<int>), StatusCodes.Status200OK)]
        public async Task<IActionResult> countbynomineeId()
        {
            var query = new GetNomineeVoteCountsQuery { };
           
            var userResult = await Sender.Send(query);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }
        /// <summary>
        /// This is the endpoint to get votes nomineeId
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("HomepageVoteMetrics")]
        [ProducesResponseType(typeof(Result<VotingMetircDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> HomepageVoteMetrics()
        {
            var query = new VoteMetricQuery
            {

            };
            var userResult = await Sender.Send(query);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This is the endpoint to get AdminVoteMetric
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("AdminMetrics")]
        [ProducesResponseType(typeof(Result<AdminVoteMetric>), StatusCodes.Status200OK)]
        public async Task<IActionResult> AdminMetrics()
        {
            var query = new AdminVoteMetricsQuerry
            {

            };
            var userResult = await Sender.Send(query);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This is the endpoint to get nominee vote counts
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("AdminGetNomineeVoteCount")]
        [ProducesResponseType(typeof(Result<VotingResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> AdminGetNomineeVoteCount([FromQuery] Guid Id)
        {
            var query = new AdminGetNomineeVoteCountsQuery
            {
                Id = Id
            };
            var userResult = await Sender.Send(query);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }


        /// <summary>
        /// This is the endpoint to get nominee votes
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("AdminGetNomineeVotes")]
        [ProducesResponseType(typeof(Result<VotingResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> AdminGetNomineeVotes([FromQuery] Guid Id, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string? search = null, string? category = null)
        {
            var query = new AdminGetNomineeVotesByIdQuery
            {
                Id = Id,
                PageNumber = pageNumber,
                PageSize = pageSize,
                SearchParam = search,
                Category = category
            };
            var userResult = await Sender.Send(query);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }
        [AllowAnonymous]
        [HttpGet("winners")]
        public async Task<IActionResult> GetCategoryWinners([FromQuery] Guid? categoryId)
        {
            // Pass the category filter to the query
            var query = new VoteWinnersQuery
            {
                CategoryId = categoryId
            };

            var result = await Sender.Send(query);

            return Ok(result);
        }


    }

}


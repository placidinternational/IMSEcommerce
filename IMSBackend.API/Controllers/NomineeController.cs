using IMSBackend.Application.Contracts;
using IMSBackend.Application.Dtos.Nominee.Response;
using IMSBackend.Application.Features.AwardFeatures.Command.Nominees;
using IMSBackend.Application.Features.AwardFeatures.Querries;
using IMSBackend.Application.Features.AwardFeatures.Querries.NomineesQuerries;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMSBackend.API.Controllers
{
    public class NomineeController : BaseController
    {
        private readonly IUserService _userService;

        public NomineeController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// This is the endpoint to create nominee account 
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Register(NomineeCommand requestModel)
        {
            var userResult = await Sender.Send(requestModel);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This is the endpoint to create nominee account 
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPut]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update(UpdateNomineeCommand requestModel)
        {
            var userResult = await Sender.Send(requestModel);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }
        /// <summary>
        /// This is the endpoint to get all Nominee
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpGet]
        [ProducesResponseType(typeof(Result<NomineeResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string? search = null, string? category = null)
        {
            var query = new GetAllNomineeQuery 
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
        /// This is the endpoint to get Nominee by id
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpGet("Id")]
        [ProducesResponseType(typeof(Result<NomineeResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get([FromQuery] Guid Id)
        {
            var query =new GetNomineeByIdQuery
            {
                Id = Id,
            };
            var userResult = await Sender.Send(query);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }
    }
}

using IMSBackend.Application.Dtos.CategoryDto;
using IMSBackend.Application.Features.AwardFeatures.Command.Categories;
using IMSBackend.Application.Features.AwardFeatures.Command.Nominees;
using IMSBackend.Application.Features.AwardFeatures.Querries.CategoryQuerries;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMSBackend.API.Controllers
{
    public class AwardCategoryController : BaseController
    {

        /// <summary>
        /// This is the endpoint to create category 
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Register(CategoryCommand requestModel)
        {
            var userResult = await Sender.Send(requestModel);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This is the endpoint to get all category 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(Result<CategoryResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var result = new GetAllCategoryQuerries { };
            var userResult = await Sender.Send(result);
            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This is the endpoint to get by Id category 
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpGet("Id")]
        [ProducesResponseType(typeof(Result<CategoryResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById(GetCategoryByIdQuery requestModel)
        {
            var userResult = await Sender.Send(requestModel);

            if (userResult.Succeeded == false)
                return BadRequest(userResult);
            else
                return Ok(userResult);
        }
    }
}

using IMSBackend.Application.Dtos.ProductDto;
using IMSBackend.Application.Features.ProductCategories.Command.Create;
using IMSBackend.Application.Features.ProductFeatures.Command.Create;
using IMSBackend.Application.Features.ProductFeatures.Querries;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMSBackend.API.Controllers
{

    public class ProductController : BaseController
    {
        // <summary>
        /// This is the endpoint to create product 
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpPost]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create(ProductCommand query, CancellationToken cancellationToken)
        {

            var userResult = await Sender.Send(query);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This endpoint is used to get all products
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(Result<GetProductResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllProducts([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string? SearchParam = null)
        {
            var query = new GetAllProductQuerry { PageNumber = pageNumber, PageSize = pageSize, SearchParam = SearchParam };
            var result = await Sender.Send(query);
            return Ok(result);
        }
    }
}


using IMSBackend.Application.Dtos.ProductCategoryDto;
using IMSBackend.Application.Features.ProductCategories.Command.Create;
using IMSBackend.Application.Features.ProductCategories.Querries;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMSBackend.API.Controllers
{
    
    public class ProductCategoryController : BaseController
    {
        // <summary>
        /// This is the endpoint to create product 
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpPost]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create(ProductCategoryCommand query, CancellationToken cancellationToken)
        {

            var userResult = await Sender.Send(query);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }

        // <summary>
        /// This is the endpoint to get all productcategories
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpGet]
        [ProducesResponseType(typeof(Result<GetProductCategoryResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductCategoriesQuerry(); 

            var userResult = await Sender.Send(query);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }
    }
}

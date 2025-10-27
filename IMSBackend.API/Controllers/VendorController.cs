using IMSBackend.Application.Dtos.Auth;
using IMSBackend.Application.Dtos.ProductDto;
using IMSBackend.Application.Features.AuthenticationFeature.Queries;
using IMSBackend.Application.Features.ProductFeatures.Querries;
using IMSBackend.Application.Features.VendorFeatures.Command.Create;
using IMSBackend.Application.Features.VendorFeatures.Querries;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMSBackend.API.Controllers
{
    public class VendorController : BaseController
    {


        // <summary>
        /// This is the endpoint to onboard vednors
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
       
        [HttpPost]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> companydetails(VendorCommand query, CancellationToken cancellationToken)
        {

            var userResult = await Sender.Send(query);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }

        // <summary>
        /// This is the endpoint to register bank details for vendors
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("bankdetails")]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> bankdetails(BankDetailsCommand query, CancellationToken cancellationToken)
        {

            var userResult = await Sender.Send(query);
            if (userResult.Succeeded == false)

                return BadRequest(userResult.Messages);
            else
                return Ok(userResult);
        }

        /// <summary>
        /// This endpoint is used to get all featured vendors
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpGet("Featured")]
        [ProducesResponseType(typeof(Result<GetProductResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllFeaturedVendors([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string? SearchParam = null)
        {
            var query = new GetAllFeaturedVendorsQuery { PageNumber = pageNumber, PageSize = pageSize};
            var result = await Sender.Send(query);
            return Ok(result);
        }

        /// <summary>
        /// This endpoint is used to get vendor shop
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpGet("GetAllVendorShop")]
        [ProducesResponseType(typeof(Result<GetProductResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllVendorShop([FromQuery] Guid VendorId, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string? SearchParam = null)
        {
            var query = new GetVendorShopQuery {VendorId = VendorId, PageNumber = pageNumber, PageSize = pageSize, SearchParam = SearchParam };
            var result = await Sender.Send(query);
            return Ok(result);
        }
    }
}

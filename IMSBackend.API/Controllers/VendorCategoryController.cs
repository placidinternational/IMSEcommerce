
using IMSBackend.Application.Features.VendorFeatures.Command.Create;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMSBackend.API.Controllers
{
    public class VendorCategoryController : BaseController
    {
        // <summary>
        /// This is the endpoint to create vendor categories
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>

        [HttpGet]
        [ProducesResponseType(typeof(Result<VendorTypeEnum>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {

            var VendorType = Enum.GetValues(typeof(VendorTypeEnum))
                                  .Cast<VendorTypeEnum>()
                                  .Select(f => new { Id = (int)f, Name = f.ToString() })
                                  .ToList();

            return Ok(VendorType);
        }
    }
}

using IMSBackend.Application.Dtos.Auth.Requests;
using IMSBackend.BackendAPI.Controllers;
using IMSBackend.Infrastructure.MediaUploadIntegration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMSBackend.API.Controllers
{
   
    public class CatalogueController : BaseController
    {
        private readonly IMediaUpload _mediaUpload;

        public CatalogueController(IMediaUpload mediaUpload)
        {
            _mediaUpload = mediaUpload;
        }

        /// <summary>
        /// Endpoint to upload image
        /// </summary>
        /// <param name="uploadModel"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [Route("Upload/Image")]
        [ProducesResponseType(typeof(PhotoUploadResult), StatusCodes.Status200OK)]
        public async Task<IActionResult> UploadImage([FromForm] UploadModelDto uploadModel)
        {
            return Ok(await _mediaUpload.UploadPhoto(uploadModel.Image));
        }

    }
}

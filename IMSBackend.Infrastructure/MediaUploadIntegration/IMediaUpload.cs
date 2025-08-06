using IMSBackend.Common;
using Microsoft.AspNetCore.Http;

namespace IMSBackend.Infrastructure.MediaUploadIntegration
{
    public interface IMediaUpload
    {
        Task<Result<PhotoUploadResult>> UploadPhoto(IFormFile file);
    }
}

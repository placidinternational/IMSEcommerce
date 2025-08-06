using AutoMapper;
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using IMSBackend.Infrastructure.MediaUploadIntegration;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using IMSBackend.Common;
using IMSBackend.Infrastructure.Settings;

namespace IMSBackend.Infrastrusture.MediaUploadIntegration;
public class CloudinaryMediaUpload : IMediaUpload
{
    private readonly IMapper mapper;
    private readonly CloudinarySettings cloudinarySettings;
    private readonly Account account;
    private readonly Cloudinary cloudinary;

    public CloudinaryMediaUpload(IMapper _mapper, IOptions<CloudinarySettings> _cloudinarySettings)
    {
        this.mapper = _mapper;
        this.cloudinarySettings = _cloudinarySettings.Value;

        account = new Account(
            cloudinarySettings.CloudName,
            cloudinarySettings.ApiKey,
            cloudinarySettings.ApiSecret
            );

        cloudinary = new Cloudinary(account);
    }

    public async Task<Result<PhotoUploadResult>> UploadPhoto(IFormFile file)
    {
        if (file.Length > 0)
        {
            // Generate a unique name for the file
            var fileExtension = Path.GetExtension(file.FileName); // Get file extension
            var uniqueFileName = $"{Guid.NewGuid()}{fileExtension}"; // Generate a unique file name with extension

            await using var stream = file.OpenReadStream();
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(uniqueFileName, stream),
                Folder = "IbadanMarketSquare"

            };

            var uploadResult = await cloudinary.UploadAsync(uploadParams);

            if (uploadResult.Error != null)
            {
                throw new Exception(uploadResult.Error.Message);
            }

            return await Result<PhotoUploadResult>.SuccessAsync(new PhotoUploadResult()
            {
                PublicId = uploadResult.PublicId,
                Url = uploadResult.SecureUrl.ToString()
            });
        }

        return null;
    }

    public async Task<List<PhotoUploadResult>> UploadBulkPhoto(List<IFormFile> files)
    {
        List<PhotoUploadResult> list = new List<PhotoUploadResult>();
        var uploadTasks = files.Select(async filePath =>
        {

            // Generate a unique name for the file
            var fileExtension = Path.GetExtension(filePath.FileName); // Get file extension
            var uniqueFileName = $"{Guid.NewGuid()}{fileExtension}"; // Generate a unique file name with extension

            await using var stream = filePath.OpenReadStream();
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(uniqueFileName, stream),

            };

            try
            {
                var uploadResult = await cloudinary.UploadAsync(uploadParams);
                list.Add(new PhotoUploadResult()
                {
                    PublicId = uploadResult.PublicId,
                    Url = uploadResult.SecureUrl.ToString()
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        });

        await Task.WhenAll(uploadTasks);
        return list;
    }

}

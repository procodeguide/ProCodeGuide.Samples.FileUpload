using Microsoft.AspNetCore.WebUtilities;

namespace ProCodeGuide.Samples.FileUpload.Interfaces
{
    public interface IStreamFileUploadService
    {
        Task<bool> UploadFile(MultipartReader reader, MultipartSection section);
    }
}

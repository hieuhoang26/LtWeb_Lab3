namespace ThucHanh1.Services
{
    public interface IBufferedFileUploadService
    {
        internal Task<bool> UploadFile(IFormFile file);
       
    }
}

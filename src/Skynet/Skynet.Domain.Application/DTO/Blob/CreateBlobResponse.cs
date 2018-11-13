namespace Skynet.Domain.Application.DTO.Blob
{
    public class CreateBlobResponse : BaseResponse
    {
        public string Path { get; set; }
        public string BlobId { get; set; }
    }
}

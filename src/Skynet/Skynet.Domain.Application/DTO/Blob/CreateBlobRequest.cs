namespace Skynet.Domain.Application.DTO.Blob
{
    public class CreateBlobRequest
    {
        public string Base64File { get; set; }
        public string Extension { get; set; }
    }
}

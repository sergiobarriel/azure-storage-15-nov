using System.Threading.Tasks;
using Skynet.Domain.Application.DTO.Blob;

namespace Skynet.Domain.Application.Abstractions
{
    public interface IBlobService
    {
        Task<CreateBlobResponse> CreateBlobAsync(CreateBlobRequest request);
    }
}

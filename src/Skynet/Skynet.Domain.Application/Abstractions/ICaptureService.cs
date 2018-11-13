using System;
using System.Threading.Tasks;
using Skynet.Domain.Application.DTO.Capture;

namespace Skynet.Domain.Application.Abstractions
{
    public interface ICaptureService
    {

        Task<Guid> CreateCaptureAsync(CreateCaptureRequest request);
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Skynet.Domain.Application.Abstractions;
using Skynet.Domain.Application.DTO.Blob;
using Skynet.Domain.Application.DTO.Capture;
using Skynet.Infrastructure.Persistence;

namespace Skynet.Domain.Application.Services
{
    public class CaptureService : ICaptureService
    {
        private readonly Context _context;
        private readonly IBlobService _blobService;

        public CaptureService(Context context, IBlobService blobService)
        {
            _context = context;
            _blobService = blobService;
        }


        public async Task<Guid> CreateCaptureAsync(CreateCaptureRequest request)
        {
            if (!await _context.Robots.AnyAsync(x => x.Id == request.RobotId)) throw new Exception($"Robot {request.RobotId} not exists.");

            var capture = new Capture(request.RobotId);

            await _context.Captures.AddAsync(capture);
            await _context.SaveChangesAsync();

            var createBlobResponse = await _blobService.CreateBlobAsync(new CreateBlobRequest()
            {
                Extension = request.Extension,
                Base64File = request.Base64File
            });

            capture.Path = createBlobResponse.Path;
            capture.BlobId = createBlobResponse.BlobId;

            await _context.SaveChangesAsync();

            return capture.Id;
        }
    }
}

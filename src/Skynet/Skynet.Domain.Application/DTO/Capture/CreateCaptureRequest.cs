using System;

namespace Skynet.Domain.Application.DTO.Capture
{
    public class CreateCaptureRequest
    {
        public Guid RobotId { get; set; }
        public string Extension { get; set; }
        public string Base64File { get; set; }
    }
}

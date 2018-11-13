using System;

namespace Skynet.Domain.Application.DTO.Capture
{
    public class CaptureResponse
    {
        public Guid Id { get; set; }
        public Guid RobotId { get; set; }
        public string Path { get; set; }
        public DateTime Created { get; set; }
    }
}

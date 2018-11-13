using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Skynet.Domain.Application.DTO.Capture;
using Skynet.Domain.Application.DTO.Robot;

namespace Skynet.Domain.Application.Abstractions
{
    public interface IRobotService
    {
        Task<IEnumerable<RobotResponse>> GetRobotsAsync();

        Task<CaptureResponse> GetLastRobotCaptureAsync(Guid robotId);
    }
}

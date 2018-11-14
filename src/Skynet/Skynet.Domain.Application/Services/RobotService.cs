using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Skynet.Domain.Application.Abstractions;
using Skynet.Domain.Application.DTO.Capture;
using Skynet.Domain.Application.DTO.Robot;
using Skynet.Infrastructure.Persistence;

namespace Skynet.Domain.Application.Services
{
    public class RobotService : IRobotService
    {
        private readonly Context _context;

        public RobotService(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all robots
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<RobotResponse>> GetRobotsAsync()
        {
            return await _context.Robots
                .Include(x => x.Captures)
                .Select(x => new RobotResponse()
                {
                    Id = x.Id,
                    Model = x.Model,
                    Captures = x.Captures.Count
                })
                .ToListAsync();
        }

        /// <summary>
        /// Get las robot capture by robot Id
        /// </summary>
        /// <param name="robotId"></param>
        /// <returns></returns>
        public async Task<CaptureResponse> GetLastRobotCaptureAsync(Guid robotId)
        {
            var total = await _context.Captures.CountAsync(x => x.RobotId == robotId);

            return await _context.Captures
                .Where(x => x.RobotId == robotId)
                .OrderByDescending(x => x.Created)
                .Select(x => new CaptureResponse()
                {
                    Id = x.Id,
                    RobotId = x.RobotId,
                    Path = x.Path,
                    Created = x.Created,
                    Total = total,
                }).FirstOrDefaultAsync();
        }
    }
}

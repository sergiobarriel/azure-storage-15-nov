using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Skynet.Domain.Application.Abstractions;
using Skynet.WebAPI.Viewmodels.Capture;
using Skynet.WebAPI.Viewmodels.Robot;

namespace Skynet.WebAPI.Controllers
{
    [Route("api/robot")]
    [ApiController]
    public class RobotController : ControllerBase
    {
        private readonly IRobotService _robotService;
        private readonly IMapper _mapper;

        public RobotController(IRobotService robotService, IMapper mapper)
        {
            _robotService = robotService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Robot>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetRobotsAsync()
        {
            var robots = await _robotService.GetRobotsAsync();

            return Ok(_mapper.Map<IEnumerable<Robot>>(robots));
        }

        #region Robot captures

        [HttpGet("{robot_id}/capture/last")]
        [ProducesResponseType(typeof(Capture), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetLastCapture(Guid robot_id)
        {
            var capture = await _robotService.GetLastRobotCaptureAsync(robot_id);

            return Ok(_mapper.Map<Capture>(capture));
        }

        #endregion
    }
}

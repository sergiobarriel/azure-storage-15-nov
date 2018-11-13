using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Skynet.Domain.Application.Abstractions;
using Skynet.Domain.Application.DTO.Capture;
using Skynet.WebAPI.Viewmodels.Capture;

namespace Skynet.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaptureController : ControllerBase
    {
        private readonly ICaptureService _captureService;
        private readonly IMapper _mapper;

        public CaptureController(ICaptureService captureService, IMapper mapper)
        {
            _captureService = captureService;
            _mapper = mapper;
        }

        /// <summary>
        /// Create capture
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(Guid), StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateCaptureAsync(CreateCapture request)
        {
            return Ok(await _captureService.CreateCaptureAsync(_mapper.Map<CreateCaptureRequest>(request)));
        }
    }
}

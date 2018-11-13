using AutoMapper;
using Skynet.Domain.Application.DTO.Capture;
using Skynet.WebAPI.Viewmodels.Capture;

namespace Skynet.WebAPI.Extensions.Automapper.Profiles
{
    public class CaptureProfile : Profile
    {
        public CaptureProfile()
        {
            // Requests
            CreateMap<CreateCapture, CreateCaptureRequest>();

            // Responses
            CreateMap<CaptureResponse, Capture>();
        }
    }
}

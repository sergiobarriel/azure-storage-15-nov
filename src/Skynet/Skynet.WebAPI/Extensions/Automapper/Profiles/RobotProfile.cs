using AutoMapper;
using Skynet.Domain.Application.DTO.Robot;
using Skynet.WebAPI.Viewmodels.Robot;

namespace Skynet.WebAPI.Extensions.Automapper.Profiles
{
    public class RobotProfile : Profile
    {
        public RobotProfile()
        {
            // Requests

            // Responses
            CreateMap<RobotResponse, Robot>();
        }
    }
}

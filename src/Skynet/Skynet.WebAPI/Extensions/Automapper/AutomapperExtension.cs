using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Skynet.WebAPI.Extensions.Automapper.Profiles;

namespace Skynet.WebAPI.Extensions.Automapper
{
    public static class AutomapperExtension
    {
        public static void RegisterAutomapper(this IServiceCollection services)
        {
            services.AddAutoMapper(config =>
            {
                config.AddProfile<CaptureProfile>();
                config.AddProfile<RobotProfile>();
                config.AddProfile<ModelProfile>();
            });
        }
    }
}

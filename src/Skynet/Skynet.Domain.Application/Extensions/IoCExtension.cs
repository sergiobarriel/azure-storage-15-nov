using Microsoft.Extensions.DependencyInjection;
using Skynet.Domain.Application.Abstractions;
using Skynet.Domain.Application.Services;

namespace Skynet.Domain.Application.Extensions
{
    public static class IoCExtension
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IRobotService, RobotService>();
            services.AddTransient<ICaptureService, CaptureService>();
            services.AddTransient<IBlobService, BlobService>();
        }
    }
}

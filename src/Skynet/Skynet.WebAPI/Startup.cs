using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Skynet.Domain.Application.Extensions;
using Skynet.Infrastructure.Persistence.Extensions;
using Skynet.WebAPI.Extensions.Automapper;
using Skynet.WebAPI.Extensions.Swagger;

namespace Skynet.WebAPI
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) => Configuration = configuration;

        /// <summary>
        /// Configure services
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(x => x.AddPolicy("MyPolicy", builder => { builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); }));           

            services.RegisterDatabase(Configuration);

            services.RegisterApplicationServices();

            services.RegisterAutomapper();

            services.RegisterSwagger();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        /// <summary>
        /// Configure
        /// </summary>
        /// <param name="app"></param>
        public void Configure(IApplicationBuilder app)
        {
            app.UseHsts();

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwaggerAndUI();
        }
    }
}

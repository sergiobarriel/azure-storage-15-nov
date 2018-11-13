using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Skynet.Web
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(x => x.AddPolicy("MyPolicy", builder => { builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); }));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
        }
    }
}

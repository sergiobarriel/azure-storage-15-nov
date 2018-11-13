using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Skynet.WebAPI.Extensions.Swagger
{
    public static class SwaggerExtension
    {
        /// <summary>
        /// Register Swagger on dependency container
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new Info()
                {
                    Title = "Swagger of skynet API",
                    Version = "1",
                    Contact = new Contact()
                    {
                        Email = "sergio.barriel@gmail.com",
                        Name = "Sergio Barriel",
                        Url = "https://twitter.com/sergiobarriel",
                    },
                    TermsOfService = string.Empty
                });
            });
        }

        /// <summary>
        /// Use Swagger (extension)
        /// </summary>
        /// <param name="application"></param>
        public static void UseSwaggerAndUI(this IApplicationBuilder application)
        {
            application.UseSwagger();

            application.UseSwaggerUI(sw =>
            {
                sw.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }
    }
}

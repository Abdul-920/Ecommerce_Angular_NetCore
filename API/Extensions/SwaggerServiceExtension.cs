using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extensions
{
    public static class SwaggerServiceExtension
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services) {
             services.AddSwaggerGen(c => { 
                c.SwaggerDoc("V1", new OpenApiInfo{Title = "Skinet Api", Version = "V1"});
            });
            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumentation( this IApplicationBuilder app) {
            app.UseSwagger();
            app.UseSwaggerUI(c => {c.SwaggerEndpoint("/swagger/V1/swagger.json", "Skinet Api V1");});
            return app;
        }
    }
}
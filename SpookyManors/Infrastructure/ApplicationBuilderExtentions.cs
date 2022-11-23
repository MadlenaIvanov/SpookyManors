using Microsoft.EntityFrameworkCore;
using SpookyManors.Data;

namespace SpookyManors.Infrastructure
{
    public static class ApplicationBuilderExtentions
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider.GetService<SpookyManorsDbContext>();

            services.Database.Migrate();


            return app;
        }
    }
}

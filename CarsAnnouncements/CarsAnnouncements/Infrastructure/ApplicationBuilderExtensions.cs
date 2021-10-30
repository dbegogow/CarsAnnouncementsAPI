using System;
using CarsAnnouncements.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarsAnnouncements.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;

            MigrateDatabase(services);

            return app;
        }

        private static void MigrateDatabase(IServiceProvider services)
        {
            var data = services
                .GetRequiredService<CarsAnnouncementsDbContext>();

            data?.Database.Migrate();
        }
    }
}
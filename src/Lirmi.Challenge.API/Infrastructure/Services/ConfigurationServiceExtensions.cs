using Lirmi.Challenge.API.Services;
using Lirmi.Challenge.Data.Context;
using Lirmi.Challenge.Data.CQS.School.Command;
using Lirmi.Challenge.Data.CQS.School.Query;
using Microsoft.EntityFrameworkCore;

namespace Lirmi.Challenge.API.Infrastructure.Services
{
    public static class ConfigurationServiceExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ISchoolService, SchoolService>();

            return services;
        }

        public static IServiceCollection RegisterCommands(this IServiceCollection services)
        {
            services.AddTransient<ISchoolCommand, SchoolCommand>();

            return services;
        }

        public static IServiceCollection RegisterQueries(this IServiceCollection services)
        {
            services.AddTransient<ISchoolQuery, SchoolQuery>();

            return services;
        }

        public static IServiceCollection RegisterContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LirmiContext>(opts =>
            {
                opts.UseNpgsql(configuration.GetConnectionString("WebApiDatabase"));
            });

            return services;
        }
    }
}

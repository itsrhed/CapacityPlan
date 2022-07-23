using CapacityPlanApp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CapacityPlanApp.Extensions
{
    public static class DBContextExtension
    {
        /// <summary>
        /// Adds the database context configuration.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns></returns>
        public static IServiceCollection AddDBContextConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(options =>
                 options.UseMySQL(configuration.GetConnectionString("MySQLDatabase")));

            return services;
        }
    }
}

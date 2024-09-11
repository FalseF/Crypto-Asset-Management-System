using Microsoft.EntityFrameworkCore;

namespace CryptoAssetManagementSystem.Infrastructure
{
    public static class AddDbContext
    {
        public static IServiceCollection AddDbContextWithConfigurations(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
            });

            return services;
        }
    }
}

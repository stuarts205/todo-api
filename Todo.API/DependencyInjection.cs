using Microsoft.EntityFrameworkCore;
using Todo.Intrastructure.Persistence.Entities;

namespace Todo.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInstrasucture(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString
                 = configuration.GetConnectionString("DatabaseConnection");

            services.AddDbContext<TodoAppDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            return services;
        }
    }
}

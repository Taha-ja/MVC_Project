using Microsoft.EntityFrameworkCore;
using WebApplicationMVC.Models.Data;

namespace WebApplicationMVC.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:EmployeConnection"];
            //var connectionString = config.GetConnectionString("connectionString");
            services.AddDbContext<EmployeDbContext>(o => o.UseSqlServer(connectionString));
        }
    }
}

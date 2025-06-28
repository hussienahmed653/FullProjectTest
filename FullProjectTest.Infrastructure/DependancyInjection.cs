using FullProjectTest.Domain.DBContextModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FullProjectTest.Infrastructure
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service, IConfiguration configuration)
        {
            var connectionstring = configuration.GetConnectionString("DefaultConnection");
            service.AddDbContext<ApplicationDBContext>(options =>
            options.UseSqlServer(connectionstring));
            return service;
        }
    }
}

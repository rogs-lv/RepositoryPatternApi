using Dapper.Application.Interfaces;
using Dapper.Infrastructure.Repositories;
using DbConnectionFactory;
using Microsoft.Extensions.DependencyInjection;

namespace Dapper.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IDbFactory, DbFactory>();
        }
    }
}

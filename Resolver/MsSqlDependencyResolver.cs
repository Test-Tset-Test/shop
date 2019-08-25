using Contracts;
using Contracts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MsSqlDataLayer;
using MsSqlDataLayer.Repositories;

namespace Resolver
{
    public class MsSqlDependencyResolver : IDependencyResolver
    {
        public void ResolveDb(IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("MsSqlConnection");
            services.AddDbContext<MsSqlContext>(options => options.UseSqlServer(connectionString));

        }

        public void ResolveRepositories(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderProductRepository, OrderProductRepository>();
        }
    }

}

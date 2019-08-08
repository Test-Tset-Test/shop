using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySqlDataLayer;
using MySqlDataLayer.Repositories;

namespace Resolver
{
    public class MsSqlDependencyResolver : IDependencyResolver
    {
        public void ResolveDB(IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("MsSqlConnection");
            services.AddDbContext<MySqlContext>(options => options.UseSqlServer(connectionString));

        }

        public void ResolveRepositories(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }

}

﻿using Contracts;
using Contracts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySqlDataLayer;
using MySqlDataLayer.Repositories;

namespace Resolver
{
    public class MySqlDependencyResolver: IDependencyResolver
    {
        public void ResolveDb(IServiceCollection services, IConfiguration configuration)
        {
            //services.Add(new ServiceDescriptor(typeof(MySqlContext), new MySqlContext(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))));
            string connectionString = configuration.GetConnectionString("MySqlConnection");
            services.AddDbContext<MySqlContext>(options => options.UseSqlServer(connectionString));

        }

        public void ResolveRepositories(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }

}

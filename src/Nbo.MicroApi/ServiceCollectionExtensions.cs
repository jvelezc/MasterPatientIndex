using Microsoft.Extensions.DependencyInjection;
using Nbo.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.AspNetCore.Hosting;

namespace Nbo.MicroApi
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEfDatabase(
            this IServiceCollection services, 
            IConfigurationRoot Configuration,
            IHostingEnvironment env
            )
        {
            var connectionString = "";
            if (env.IsDevelopment())
            {
                connectionString = Configuration["Development:ConnectionString"];
            }
            else if (env.IsStaging())
            {
                connectionString = Configuration["Staging:ConnectionString"];
            }
            else if (env.IsProduction())
            {
                connectionString = Configuration["Production:ConnectionString"];
            }
            services
             .AddEntityFramework()
             .AddEntityFrameworkSqlServer()
             .AddDbContext<NboCtx>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}

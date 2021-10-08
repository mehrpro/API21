using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.IServices;
using Entities.Models;
using LoggerServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace API21.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection service)
        {
            service.AddCors(opts =>
            {
                opts.AddPolicy("CorsPolicy",
                    builder => { builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); });
            });

        }

        public static void ConfigureIISIntegration(this IServiceCollection service)
        {
            service.Configure<IISOptions>(opts => { });
        }

        public static void ConfigureLoggerManager(this IServiceCollection service)
        {
            service.AddScoped<ILoggerManager, LoggerManager>();
        }


        public static void ConfigureSqlService(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<Api21DbContext>(opts =>
            {
                opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("API21"));
            });

        }
    }
}

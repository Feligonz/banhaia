using Gestion.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Logic.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLogicServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<GestionDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<GestionLogic>();

            return services;
        }
    }
}

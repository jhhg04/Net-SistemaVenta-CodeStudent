using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SistemaVenta.DAL.DBContext;

namespace SistemaVenta.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependecia(this IServiceCollection services, IConfiguration configuration) {
            services.AddDbContext<DBVENTAContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
            });
        }
    }
}

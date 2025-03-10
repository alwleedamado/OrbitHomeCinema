using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrbitHomeCinema.Core.Interfaces;
using OrbitHomeCinema.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitHomeCinema.Data
{
    public static class DependencyInjection
    {
        public static void AddData(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<HomeCinemaDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}

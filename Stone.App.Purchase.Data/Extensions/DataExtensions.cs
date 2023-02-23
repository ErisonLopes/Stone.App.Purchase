using Microsoft.Extensions.DependencyInjection;
using Stone.App.Purchase.Data.Repositories;
using Stone.App.Purchase.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.App.Purchase.Data.Extensions
{
    public static class DataExtensions
    {

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services
                .AddSingleton<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}

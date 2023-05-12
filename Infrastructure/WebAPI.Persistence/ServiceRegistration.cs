using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Abstractions;
using WebAPI.Persistence.Concretes;

namespace WebAPI.Persistence
{
    public static class ServiceRegistration
    {
       public static void AddPersistenceServices(
           this IServiceCollection services)
        {
            services.AddSingleton<IProductService,ProductService>();
        }
    }
}

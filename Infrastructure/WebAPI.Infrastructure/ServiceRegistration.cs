using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Abstractions.Storage;
using WebAPI.Infrastructure.Services;
using WebAPI.Infrastructure.Services.Storage;

namespace WebAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();
        }

        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T:class,IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Abstractions.Storage;
using WebAPI.Application.Abstractions.Token;
using WebAPI.Infrastructure.Services.Storage;
using WebAPI.Infrastructure.Services.Token;

namespace WebAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
        }

        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T:class,IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }
    }
}

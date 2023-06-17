using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Services;
using WebAPI.Infrastructure.Services;

namespace WebAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceDescriptors )
        {
            serviceDescriptors.AddScoped<IFileService, FileService>();
        }
    }
}

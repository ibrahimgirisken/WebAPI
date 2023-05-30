﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Abstractions;
using WebAPI.Application.Repositories.Product;
using WebAPI.Persistence.Concretes;
using WebAPI.Persistence.Contexts;

namespace WebAPI.Persistence
{
    public static class ServiceRegistration
    {
       public static void AddPersistenceServices(
           this IServiceCollection services)
        {
            services.AddDbContext<WebAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            //services.AddScoped<IProductReadRepository, ProductReadRepository>();
        }
    }
}

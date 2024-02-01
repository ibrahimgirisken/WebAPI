using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAPI.Application.Abstractions.Services;
using WebAPI.Application.Abstractions.Services.Authentications;
using WebAPI.Application.Repositories;
using WebAPI.Domain.Entities.Identity;
using WebAPI.Persistence.Contexts;
using WebAPI.Persistence.Repositories;
using WebAPI.Persistence.Services;

namespace WebAPI.Persistence
{
    public static class ServiceRegistration
    {
       public static void AddPersistenceServices(
           this IServiceCollection services)
        {
            services.AddDbContext<WebAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false; 
                options.Password.RequireNonAlphanumeric = false;
            })
            
            .AddEntityFrameworkStores<WebAPIDbContext>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<ICategoryReadRepository,CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<IFileReadRepository, FileReadRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();
            services.AddScoped<IPdfFileReadRepository, PdfFileReadRepository>();
            services.AddScoped<IPdfFileWriteRepository, PdfFileWriteRepository>();
            services.AddScoped<IProductImageFileReadRepository, ProductImageFileReadRepository>();
            services.AddScoped<IProductImageFileWriteRepository, ProductImageFileWriteRepository>();

            services.AddScoped<IUserService,UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IInternalAuthentication, AuthService>();
            services.AddScoped<IExternalAuthentication, AuthService>();
        }
    }
}

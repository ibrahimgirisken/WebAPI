using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Entities;
using WebAPI.Domain.Entities.Common;
using WebAPI.Domain.Entities.Identity;

namespace WebAPI.Persistence.Contexts
{
    public class WebAPIDbContext : IdentityDbContext<AppUser,AppRole,string>
    {
        public WebAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTranslations> ProductTranslations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Domain.Entities.File> Files { get; set; }
        public DbSet<ProductImageFile> ProductImageFiles { get; set; }
        public DbSet<PdfFile> PdfFiles { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas=ChangeTracker.Entries<BaseEntity>();
            foreach(var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _=> DateTime.UtcNow
                };
           }
            
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}

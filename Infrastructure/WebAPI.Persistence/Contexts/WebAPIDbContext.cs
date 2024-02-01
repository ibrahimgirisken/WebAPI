using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Entities;
using WebAPI.Domain.Entities.Common;
using WebAPI.Domain.Entities.Identity;

namespace WebAPI.Persistence.Contexts
{
    public class WebAPIDbContext :IdentityDbContext<AppUser,AppRole,string>
    {
        public WebAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTranslations> ProductTranslations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryTranslations> CategoryTranslations { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<BlogTranslations> BlogTranslations { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsTranslations> NewsTranslations { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderTranslations> SliderTranslations { get; set; }
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("dbo");

            builder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.HasKey(l => new { l.LoginProvider, l.ProviderKey });
            });

            builder.Entity<Product>(entity =>
            {
                entity.ToTable(nameof(Product));
                entity.Property(i=>i.Image1).HasColumnName("Image1").HasColumnType("nvarchar").HasMaxLength(100);
                entity.Property(i=>i.Image2).HasColumnName("Image2").HasColumnType("nvarchar").HasMaxLength(100);
                entity.Property(i=>i.Image3).HasColumnName("Image3").HasColumnType("nvarchar").HasMaxLength(100);
                entity.Property(i=>i.Image4).HasColumnName("Image4").HasColumnType("nvarchar").HasMaxLength(100);
                entity.Property(i=>i.Image5).HasColumnName("Image5").HasColumnType("nvarchar").HasMaxLength(100);
                entity.Property(i=>i.OrderNumber).HasColumnName("OrderNumber").HasColumnType("int");
                entity.Property(i => i.Status).HasColumnName("Status");
                entity.Property(i => i.UpdatedDate).HasColumnName("UpdatedDate");
                entity.Property(i => i.CreatedDate).HasColumnName("CreatedDate");

                entity.HasMany(i => i.Translations)
                      .WithOne(i=>i.Product)
                      .HasForeignKey(i=>i.ProductId)
                      .HasConstraintName("product_translation_id_fk");
            });

            builder.Entity<ProductTranslations>(entity =>
            {
                entity.Property(i => i.Name).HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(120);
                entity.Property(i => i.Content).HasColumnName("Content").HasColumnType("text");
                entity.Property(i => i.LanguageCode).HasColumnName("LanguageCode").HasColumnType("nvarchar").HasMaxLength(3);
                entity.Property(i => i.PageTitle).HasColumnName("PageTitle").HasColumnType("nvarchar").HasMaxLength(120);
                entity.Property(i => i.UpdatedDate).HasColumnName("UpdatedDate");
                entity.Property(i => i.CreatedDate).HasColumnName("CreatedDate");
                entity.Property(i => i.Url).HasColumnName("Url").HasColumnType("nvarchar").HasMaxLength(120);
            });


            builder.Entity<Category>(entity =>
            {
                entity.ToTable(nameof(Category));
                entity.Property(i => i.OrderNumber).HasColumnName("OrderNumber").HasColumnType("int");
                entity.Property(i => i.Status).HasColumnName("Status");
                entity.Property(i => i.Image1).HasColumnName("image1").HasColumnType("nvarchar").HasMaxLength(120);
                entity.Property(i => i.CreatedDate).HasColumnName("CreatedDate");
                entity.Property(i => i.UpdatedDate).HasColumnName("UpdatedDate");
                entity.HasMany(i => i.Translations)
                .WithOne(i => i.Category)
                .HasForeignKey(i => i.CategoryId)
                .HasConstraintName("category_translation_id_fk");
                entity.HasMany(i => i.Products)
                .WithOne(i => i.Category)
                .HasForeignKey(i=>i.CategoryId)
                .HasConstraintName("category_id_fk");
            });
        }
    }
}

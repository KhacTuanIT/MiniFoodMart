using CommonLibrary.Entities;
using CommonLibrary.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommonLibrary.Context
{
    public class MartContext : IdentityDbContext<AppUser, AppRole, Guid,
        IdentityUserClaim<Guid>, AppUserRole,
        IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>,
        IdentityUserToken<Guid>>
    {
        public MartContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();

            builder.Entity<AppRole>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

            builder.Entity<Product>()
                .HasMany(p => p.Tags)
                .WithMany(t => t.Products)
                .UsingEntity(
                    "ProductTag",
                    l => l.HasOne(typeof(Tag)).WithMany().HasForeignKey("TagId").HasPrincipalKey(nameof(Tag.Id)),
                    r => r.HasOne(typeof(Product)).WithMany().HasForeignKey("ProductId").HasPrincipalKey(nameof(Product.Id)),
                    j => j.HasKey("ProductId", "TagId"));

            builder.Entity<Product>()
                .HasMany(p => p.Categories)
                .WithMany(c => c.Products)
                .UsingEntity(
                    "ProductCategory",
                    l => l.HasOne(typeof(Category)).WithMany().HasForeignKey("CategoryId").HasPrincipalKey(nameof(Category.Id)),
                    r => r.HasOne(typeof(Product)).WithMany().HasForeignKey("ProductId").HasPrincipalKey(nameof(Product.Id)),
                    j => j.HasKey("ProductId", "CatecoryId"));

            builder.Entity<Product>()
                .HasOne(p => p.ProductType)
                .WithOne(t => t.Product)
                .HasForeignKey<ProductType>(p => p.ProductId);

            builder.Entity<Product>()
                .HasOne(p => p.ProductStock)
                .WithOne(t => t.Product)
                .HasForeignKey<ProductStock>(p => p.ProductId);

            builder.Entity<Product>()
                .HasMany(p => p.Discounts)
                .WithOne(d => d.Product)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ProductType>()
                .HasMany(p => p.ProductUnits)
                .WithOne(u => u.ProductType)
                .HasForeignKey(u => u.ProductTypeId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.ApplyUtcDateTimeConverter();
        }
    }
}

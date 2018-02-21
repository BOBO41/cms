using cms.Data.EF.Configurations;
using cms.Data.EF.Extensions;
using cms.Data.Entities;
using cms.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cms.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Function> Functions { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> ContactDetails { get; set; }
        public DbSet<DisplayContent> DisplayContents { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductExpand> ProductExpands { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<Bill> Bills { set; get; }
        public DbSet<BillDetail> BillDetails { set; get; }
        public DbSet<Color> Colors { set; get; }
        public DbSet<Size> Sizes { set; get; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Identity Config
            builder.Entity<IdentityUserClaim<string>>().ToTable("AppUserClaims").HasKey(x => x.Id);

            builder.Entity<IdentityRoleClaim<string>>().ToTable("AppRoleClaims")
                .HasKey(x => x.Id);

            builder.Entity<IdentityUserLogin<string>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            builder.Entity<IdentityUserRole<string>>().ToTable("AppUserRoles")
                .HasKey(x => new { x.RoleId, x.UserId });

            builder.Entity<IdentityUserToken<string>>().ToTable("AppUserTokens")
               .HasKey(x => new { x.UserId });

            #endregion Identity Config

            builder.AddConfiguration(new TagConfiguration());
            builder.AddConfiguration(new ProductTagConfiguration());
            builder.AddConfiguration(new FunctionConfiguration());
            builder.AddConfiguration(new PostTagConfiguration());

            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
            foreach (EntityEntry item in modified)
            {
                var changedOrAddedItem = item.Entity as IDateTracking;
                if (changedOrAddedItem != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        changedOrAddedItem.DateCreated = DateTime.Now;
                    }
                    changedOrAddedItem.DateModified = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}

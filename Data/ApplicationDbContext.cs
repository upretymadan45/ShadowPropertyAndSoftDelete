using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using dropdown.Extensions;
using dropdown.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dropdown.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ModelBuilderExtension();
            
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            BeforeSaveChanges();

            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            BeforeSaveChanges();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void BeforeSaveChanges()
        {
            ChangeTracker.DetectChanges();
            var timestamp = DateTime.Now;

            foreach (var model in ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted))
            {
                switch (model.State)
                {
                    case EntityState.Added:
                        model.Property("CreatedAt").CurrentValue = timestamp;
                        break;

                    case EntityState.Modified:
                        model.Property("UpdatedAt").CurrentValue = timestamp;
                        break;

                    case EntityState.Deleted:
                        if (model.Entity is ISoftDelete)
                        {
                            model.State = EntityState.Modified;
                            model.Property("RecStatus").CurrentValue = 'D';
                        }
                        else
                        {
                            model.State = EntityState.Deleted;
                        }

                        break;
                }
            }
        }
    }
}

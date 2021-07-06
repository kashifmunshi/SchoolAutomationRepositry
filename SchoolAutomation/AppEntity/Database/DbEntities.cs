using System;
using System.Threading;
using System.Threading.Tasks;
using AppEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace AppEntity.Database
{
    public class DbEntities : DbContext
    {
        public DbEntities(DbContextOptions<DbEntities> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedData();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = new())
        {
            foreach (var entry in ChangeTracker.Entries())
                switch (entry.State)
                {
                    case EntityState.Added when entry.Entity is BaseModel:
                        entry.Property(nameof(BaseModel.CreatedBy)).CurrentValue = 1;
                        entry.Property(nameof(BaseModel.CreatedTime)).CurrentValue = DateTime.UtcNow;
                        break;
                }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
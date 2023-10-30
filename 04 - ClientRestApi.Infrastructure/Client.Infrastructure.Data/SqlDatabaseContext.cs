using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Client.Infrastructure.Data
{
    public class SqlDatabaseContext : DbContext
    {
        public SqlDatabaseContext() { }

        public SqlDatabaseContext(DbContextOptions<SqlDatabaseContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> MyProperty { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasOne(ad => ad.Address)
                .WithOne(us => us.User)
                .HasForeignKey<Address>(ad => ad.Id);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreationDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreationDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreationDate").IsModified = false;
                }


            }

            return base.SaveChanges();
        }
    }
}
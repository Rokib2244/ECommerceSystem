using ECommerceSystem.Training.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Training.Contexts
{
    public class TrainingContext :DbContext, ITrainingContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;
        public TrainingContext( string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
           if(!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m=> m.MigrationsAssembly(_migrationAssemblyName));
            }
            base.OnConfiguring(dbContextOptionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to many relationship
            modelBuilder.Entity<Category>()
                .HasMany(p => p.Products)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryId);
            

            modelBuilder.Entity<ProductCustomers>()
                .HasKey(pc => new { pc.CustomerId, pc.ProductId });

            modelBuilder.Entity<ProductCustomers>()
                .HasOne( pc => pc.Customer)
                .WithMany(c => c.PurchasedProduct)
                .HasForeignKey( pc => pc.CustomerId);

            modelBuilder.Entity<ProductCustomers>()
                .HasOne( pc => pc.Product)
                .WithMany( p => p.CustomerPurchase)
                .HasForeignKey( pc => pc.ProductId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}

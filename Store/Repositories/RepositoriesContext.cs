﻿
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
    : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product() { ProductId = 1, ProductName = "Computer", Price = 40_000 },
                new Product() { ProductId = 2, ProductName = "Keyboard", Price = 4_000 },
                new Product() { ProductId = 3, ProductName = "Mouse", Price = 1_000 },
                new Product() { ProductId = 4, ProductName = "Monitor", Price = 15_000 },
                new Product() { ProductId = 5, ProductName = "CPU", Price = 10_000 }

            );
        }

    }
}
 

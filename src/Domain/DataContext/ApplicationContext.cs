using System.Security.Cryptography.Xml;
using System;
using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities.Selling;
using POS.Domain.Entities;
using IdentityModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace POS.Domain.DataContext;

public class ApplicationContext : IdentityDbContext<User>
{
    public ApplicationContext() { }
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Receipt> Receipts { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PosDB;");

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Category>()
               .HasMany(p => p.Products)
               .WithOne(c => c.Category)
               .HasForeignKey(p => p.CategoryId)
               .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<Product>()
               .HasMany(p => p.ProductItems)
               .WithOne(p => p.Product)
               .HasForeignKey(p => p.ProductId)
               .OnDelete(DeleteBehavior.NoAction);

        base.OnModelCreating(builder);
    }
}
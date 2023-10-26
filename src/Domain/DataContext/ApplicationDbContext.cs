using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities.Selling;
using POS.Domain.Entities;
using POS.Domain.Entities.Auth;

namespace POS.Domain.DataContext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) 
    {
        Database.EnsureCreated();
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Receipt> Receipts { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<User> Users { get; set; }

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

        builder.Entity<User>()
               .HasData(new List<User>()
               {
                   new User()
                   {
                       Id = 1,
                       FirstName = "Super",
                       LastName = "Admin",
                       PhoneNumber = "998901234567",
                       IsDeleted = false,
                       LastModifiedDate = DateTime.Now,
                       PasswordHash = "QWRtaW4uMTIzJA==",
                       Role = Enums.Role.SuperAdmin
                   }
               });

        base.OnModelCreating(builder);
    }
}
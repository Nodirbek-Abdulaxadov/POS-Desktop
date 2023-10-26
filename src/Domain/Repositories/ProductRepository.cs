using POS.Domain.DataContext;
using POS.Domain.Entities;
using POS.Domain.Interfaces;

namespace DataLayer.Repositories;

public class ProductRepository : Repository<Product>, IProductInterface
{
    public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

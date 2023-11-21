using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using POS.Domain.DataContext;
using POS.Domain.Entities;
using POS.Domain.Interfaces;

namespace POS.Domain.Repositories;
public class ProductItemRepository : Repository<ProductItem>, IProductItemInterface
{
    public ProductItemRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<ProductItem>> GetAllWithProductAsync()
        => await _dbContext.ProductItems
                           .Include(p => p.Product)
                           .ToListAsync();
}
using DataLayer.Repositories;
using POS.Domain.DataContext;
using POS.Domain.Entities;
using POS.Domain.Interfaces;

namespace POS.Domain.Repositories;
public class ProductItemRepository : Repository<ProductItem>, IProductItemInterface
{
    public ProductItemRepository(ApplicationContext dbContext) : base(dbContext)
    {
    }
}
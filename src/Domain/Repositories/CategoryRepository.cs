using POS.Domain.DataContext;
using POS.Domain.Entities;
using POS.Domain.Interfaces;

namespace DataLayer.Repositories;

public class CategoryRepository : Repository<Category>, ICategoryInterface
{
    public CategoryRepository(ApplicationContext dbContext) : base(dbContext)
    {
    }
}
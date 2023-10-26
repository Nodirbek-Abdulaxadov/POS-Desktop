using POS.Domain.DataContext;
using POS.Domain.Entities.Selling;
using POS.Domain.Interfaces;

namespace DataLayer.Repositories;

public class ReceiptRepository : Repository<Receipt>, IReceiptInterface
{
    public ReceiptRepository(ApplicationDbContext dbContext) 
        : base(dbContext)
    {
    }
}

using POS.Domain.DataContext;
using POS.Domain.Entities.Selling;
using POS.Domain.Interfaces;

namespace DataLayer.Repositories;

public class TransactionRepository : Repository<Transaction>, ITransactionInterface
{
    public TransactionRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
using POS.Domain.DataContext;
using POS.Domain.Interfaces;

namespace DataLayer.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationContext _dbContext;

    public UnitOfWork(ApplicationContext dbContext,
                       IProductInterface productInterface,
                       IReceiptInterface receiptInterface,
                       ITransactionInterface transactionInterface,
                       ICategoryInterface categories)
    {
        _dbContext = dbContext;
        Products = productInterface;
        Receipts = receiptInterface;
        Transactions = transactionInterface;
        Categories = categories;
    }

    public IProductInterface Products { get; }

    public IReceiptInterface Receipts { get; }

    public ITransactionInterface Transactions { get; }

    public ICategoryInterface Categories { get; }

    public void Dispose()
            => GC.SuppressFinalize(this);

    public async Task SaveAsync()
        => await _dbContext.SaveChangesAsync();
}

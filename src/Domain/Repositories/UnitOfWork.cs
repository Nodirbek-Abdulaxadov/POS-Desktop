using POS.Domain.DataContext;
using POS.Domain.Interfaces;

namespace DataLayer.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;

    public UnitOfWork(ApplicationDbContext dbContext,
                       IProductInterface productInterface,
                       IReceiptInterface receiptInterface,
                       ITransactionInterface transactionInterface,
                       ICategoryInterface categories,
                       IProductItemInterface productItemInterface,
                       IUserInterface userInterface)
    {
        _dbContext = dbContext;
        Products = productInterface;
        Receipts = receiptInterface;
        Transactions = transactionInterface;
        Categories = categories;
        ProductItems = productItemInterface;
        Users = userInterface;
    }

    public IProductInterface Products { get; }

    public IReceiptInterface Receipts { get; }

    public ITransactionInterface Transactions { get; }

    public ICategoryInterface Categories { get; }

    public IProductItemInterface ProductItems { get; }

    public IUserInterface Users { get; }

    public void Dispose()
            => GC.SuppressFinalize(this);
}

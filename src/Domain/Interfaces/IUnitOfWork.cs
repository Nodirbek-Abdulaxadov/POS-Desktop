﻿
namespace POS.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IProductInterface Products { get; }
    IReceiptInterface Receipts { get; }
    ITransactionInterface Transactions { get; }
    ICategoryInterface Categories { get; }
    Task SaveAsync();
}

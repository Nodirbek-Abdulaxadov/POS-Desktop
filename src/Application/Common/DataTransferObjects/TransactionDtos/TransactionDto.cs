using POS.Application.Common.Models;
using POS.Domain.Entities.Selling;

namespace POS.Application.Common.DataTransferObjects.TransactionDtos;
public class TransactionDto : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public string MadeIn { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Barcode { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public int AvailableCount { get; set; }
    public int ReceiptId { get; set; }

    public static explicit operator Transaction(TransactionDto v)
        => new()
        {
            Id = 0,
            IsDeleted = false,
            ProductId = 0,
            Quantity = v.Quantity,
            ReceiptId = 0,
            TotalPrice = v.TotalPrice
        };
}
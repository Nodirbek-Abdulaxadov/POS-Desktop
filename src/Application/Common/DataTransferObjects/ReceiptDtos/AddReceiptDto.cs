using POS.Application.Common.Models;
using POS.Domain.Entities.Selling;

namespace POS.Application.Common.DataTransferObjects.ReceiptDtos;

public class AddReceiptDto
{
    public decimal TotalPrice { get; set; }
    public decimal Discount { get; set; }
    public decimal PaidCash { get; set; }
    public decimal PaidCard { get; set; }
    public bool HasLoan { get; set; }
    public string SellerId { get; set; } = string.Empty;

    public static explicit operator Receipt(AddReceiptDto v)
        => new()
        {
            TotalPrice = v.TotalPrice,
            PaidCash = v.PaidCash,
            PaidCard = v.PaidCard,
            SellerId = v.SellerId,
            IsDeleted = false,
            LastModifiedDate = LocalTime.GetUtc5Time()
        };
}
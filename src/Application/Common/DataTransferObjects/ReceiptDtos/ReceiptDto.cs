using IdentityModels;
using POS.Application.Common.Models;
using POS.Domain.Entities.Selling;

namespace POS.Application.Common.DataTransferObjects.ReceiptDtos;
public class ReceiptDto : BaseModel
{
    public decimal TotalPrice { get; set; }
    public decimal PaidCash { get; set; }
    public decimal PaidCard { get; set; }
    public string SellerId { get; set; } = string.Empty;
    public User Seller = new();

    public static implicit operator ReceiptDto(Receipt receipt)
        => new()
        {
            Id = receipt.Id,
            TotalPrice = receipt.TotalPrice,
            PaidCard = receipt.PaidCard,
            PaidCash = receipt.PaidCash,
            SellerId = receipt.SellerId,
            Seller = receipt.Seller
        };
}
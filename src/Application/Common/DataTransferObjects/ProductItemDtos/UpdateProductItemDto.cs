using POS.Application.Common.Models;
using POS.Domain.Entities;

namespace POS.Application.Common.DataTransferObjects.WarehouseItemDtos;

public class UpdateWarehouseItemDto
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime AddedDate { get; set; }
    public decimal BuyingPrice { get; set; }
    public decimal SellingPrice { get; set; }

    public int ProductId { get; set; }
    public string AdminId { get; set; } = string.Empty;

    public static explicit operator ProductItem(UpdateWarehouseItemDto v)
         => new()
         {
             Id = v.Id,
             AdminId = v.AdminId,
             ProductId = v.ProductId,
             BuyingPrice = v.BuyingPrice,
             SellingPrice = v.SellingPrice,
             AddedDate = v.AddedDate,
             Amount = v.Amount,
             LastModifiedDate = LocalTime.GetUtc5Time()
         };
}

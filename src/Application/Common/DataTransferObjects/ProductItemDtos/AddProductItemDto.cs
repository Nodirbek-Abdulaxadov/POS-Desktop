using System.ComponentModel.DataAnnotations;
using POS.Application.Common.Models;
using POS.Domain.Entities;

namespace POS.Application.Common.DataTransferObjects.WarehouseItemDtos;

public class AddProductItemDto
{
    public decimal Amount { get; set; }
    public DateTime BroughtDate { get; set; }
    public decimal BuyingPrice { get; set; }
    public decimal SellingPrice { get; set; }
    public int ProductId { get; set; }
    [Required]
    public int AdminId { get; set; }

    public static explicit operator ProductItem(AddProductItemDto v)
        => new()
        {
            Amount = v.Amount,
            SellingPrice = v.SellingPrice,
            ProductId = v.ProductId,
            AdminId = v.AdminId,
            BuyingPrice = v.BuyingPrice,
            AddedDate = LocalTime.GetUtc5Time()
        };
}
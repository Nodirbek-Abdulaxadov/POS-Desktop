﻿using POS.Application.Common.Models;
using POS.Domain.Entities;

namespace BLL.Dtos.WarehouseItemDtos;

public class ProductItemDto : BaseModel
{
    public decimal Amount { get; set; }
    public DateTime AddedDate { get; set; }
    public decimal BuyingPrice { get; set; }
    public decimal SellingPrice { get; set; }
    public int ProductId { get; set; }
    public string AdminId { get; set; } = string.Empty;

    public static explicit operator ProductItemDto(ProductItem v)
        => new()
        {
            Id = v.Id,
            Amount = v.Amount,
            SellingPrice = v.SellingPrice,
            ProductId = v.ProductId,
            AdminId = v.AdminId,
            AddedDate = v.AddedDate,
            BuyingPrice = v.BuyingPrice
        };
}
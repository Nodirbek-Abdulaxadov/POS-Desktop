﻿using System.ComponentModel.DataAnnotations;
using POS.Application.Common.Models;
using POS.Domain.Entities;

namespace BLL.Dtos.WarehouseItemDtos;

public class AddProductItemDto
{
    public decimal Amount { get; set; }
    public DateTime BroughtDate { get; set; }
    public decimal BuyingPrice { get; set; }
    public decimal SellingPrice { get; set; }
    public int ProductId { get; set; }
    [Required]
    public string AdminId { get; set; } = string.Empty;

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
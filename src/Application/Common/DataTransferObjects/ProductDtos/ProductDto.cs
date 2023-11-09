using POS.Application.Common.Models;
using POS.Domain.Entities;
using POS.Domain.Enums;

namespace POS.Application.Common.DataTransferObjects.ProductDtos;
public class ProductDto : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public decimal WarningAmount { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Barcode { get; set; } = string.Empty;
    public DateTime ExpirationDate { get; set; }
    public decimal Amount { get; set; }
    public MeasurmentType MeasurmentType { get; set; }
    public int CategoryId { get; set; }
    public Category Category = new();

    public static implicit operator ProductDto(Product product)
         => new()
         {
             Id = product.Id,
             Name = product.Name,
             WarningAmount = product.WarningAmount,
             Description = product.Description,
             Barcode = product.Barcode,
             Amount = product.Amount,
             MeasurmentType = product.MeasurmentType,
             CategoryId = product.CategoryId,
             Category = product.Category
         };
}
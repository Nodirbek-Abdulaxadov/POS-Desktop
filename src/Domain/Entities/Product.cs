using System.ComponentModel.DataAnnotations;
using POS.Domain.Common;
using POS.Domain.Entities.Selling;
using POS.Domain.Enums;

namespace POS.Domain.Entities;

public class Product : BaseEntity
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    public decimal WarningAmount { get; set; }
    [StringLength(200)]
    public string Description { get; set; } = string.Empty;
    [StringLength(20)]
    public string Barcode { get; set; } = string.Empty;
    public DateTime ExpirationDate { get; set; }
    public decimal Amount { get; set; }
    [Required]
    public MeasurmentType MeasurmentType { get; set; }
    [Required]
    public int CategoryId { get; set; }
    public Category Category = new();

    public IEnumerable<ProductItem> ProductItems = new List<ProductItem>();
}

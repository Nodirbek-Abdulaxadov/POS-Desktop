using System.ComponentModel.DataAnnotations;
using POS.Domain.Common;

namespace POS.Domain.Entities;

public class Product : BaseEntity
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    public int WarningCount { get; set; }
    [StringLength(200)]
    public string Description { get; set; } = string.Empty;
    [StringLength(20)]
    public string Barcode { get; set; } = string.Empty;
    [StringLength(50)]
    public string MadeIn { get; set; } = string.Empty;
    public int Quantity { get; set; } = 0;
    [Required]
    public int CategoryId { get; set; }

    [Required]
    public int SubcategoryId { get; set; }

    public string AdminId { get; set; } = string.Empty;

    public IEnumerable<WarehouseItem> Products = new List<WarehouseItem>();
}

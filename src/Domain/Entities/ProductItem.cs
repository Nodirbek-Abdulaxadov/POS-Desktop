using POS.Domain.Common;

namespace POS.Domain.Entities;
public class ProductItem : BaseEntity
{
    public DateTime AddedDate { get; set; }
    public decimal BuyingPrice { get; set; }
    public decimal SellingPrice { get; set; }
    public decimal Amount { get; set; }

    public int ProductId { get; set; }
    public Product Product = new();

    public string AdminId { get; set; } = string.Empty;
}
using POS.Domain.Common;
using POS.Domain.Entities.Auth;

namespace POS.Domain.Entities;
public class ProductItem : BaseEntity
{
    public DateTime AddedDate { get; set; }
    public decimal BuyingPrice { get; set; }
    public decimal SellingPrice { get; set; }
    public decimal Amount { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int ProductId { get; set; }
    public Product Product = new();

    public int AdminId { get; set; }
    public User Admin = new();
}
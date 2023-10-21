using System.ComponentModel.DataAnnotations;
using POS.Domain.Common;
using POS.Domain.Entities.Auth;

namespace POS.Domain.Entities.Selling;
public class Receipt : BaseEntity
{
    [Required]
    public decimal TotalPrice { get; set; }
    [Required]
    public decimal PaidCash { get; set; }
    [Required]
    public decimal PaidCard { get; set; }

    [Required]
    public string SellerId { get; set; } = string.Empty;
    [Required]
    public User Seller = new();

    public IEnumerable<Transaction> Transactions = new List<Transaction>();
}

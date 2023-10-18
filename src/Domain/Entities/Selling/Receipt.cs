using System.ComponentModel.DataAnnotations;
using POS.Domain.Common;

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

    public IEnumerable<Transaction> Transactions = new List<Transaction>();
}

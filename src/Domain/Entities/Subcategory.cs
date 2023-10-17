using POS.Domain.Common;

namespace POS.Domain.Entities;

public class Subcategory : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public Category Category = new();

    public IEnumerable<Product> Subcategories = new List<Product>();
}
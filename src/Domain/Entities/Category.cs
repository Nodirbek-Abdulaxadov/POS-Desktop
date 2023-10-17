using POS.Domain.Common;

namespace POS.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public IEnumerable<Subcategory> Subcategories = new List<Subcategory>();
}
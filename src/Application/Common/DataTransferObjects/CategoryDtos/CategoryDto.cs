using POS.Application.Common.Models;
using POS.Domain.Entities;

namespace POS.Application.Common.DataTransferObjects.CategoryDtos;
public class CategoryDto : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public bool IsDeleted { get; set; }

    public static implicit operator CategoryDto(Category category)
        => new()
        {
            Id = category.Id,
            IsDeleted = category.IsDeleted,
            Name = category.Name,
        };
}
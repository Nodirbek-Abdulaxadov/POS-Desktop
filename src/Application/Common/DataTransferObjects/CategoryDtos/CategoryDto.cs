using POS.Application.Common.Models;
using POS.Domain.Entities;

namespace POS.Application.Common.DataTransferObjects.CategoryDtos;
public class CategoryDto : BaseModel
{
    public string Name { get; set; } = string.Empty;

    public static implicit operator CategoryDto(Category category)
        => new()
        {
            Id = category.Id,
            Name = category.Name,
        };
}
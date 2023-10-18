using POS.Application.Common.Models;
using POS.Domain.Entities;

namespace POS.Application.Common.DataTransferObjects.CategoryDtos;
public class AddCategoryDto
{
    public string Name { get; set; } = string.Empty;

    public static implicit operator Category(AddCategoryDto dto)
        => new()
        {
            Name = dto.Name,
            LastModifiedDate = LocalTime.GetUtc5Time()
        };
}
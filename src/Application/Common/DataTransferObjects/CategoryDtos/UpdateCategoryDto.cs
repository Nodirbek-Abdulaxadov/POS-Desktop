using POS.Application.Common.Models;
using POS.Domain.Entities;

namespace POS.Application.Common.DataTransferObjects.CategoryDtos;
public class UpdateCategoryDto : BaseModel
{
    public string Name { get; set; } = string.Empty;

    public static implicit operator Category(UpdateCategoryDto dto)
        => new()
        {
            Id = dto.Id,
            Name = dto.Name,
        };
}
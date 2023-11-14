using POS.Application.Common.Models;
using POS.Domain.Entities;
using POS.Domain.Enums;

namespace POS.Application.Common.DataTransferObjects.ProductDtos;
public class AddProductDto
{
    public string Name { get; set; } = string.Empty;
    public decimal WarningAmount { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Barcode { get; set; } = string.Empty;
    public MeasurmentType MeasurmentType { get; set; }
    public int CategoryId { get; set; }

    public static implicit operator Product(AddProductDto dto)
        => new()
        {
            Name = dto.Name,
            WarningAmount = dto.WarningAmount,
            Description = dto.Description,
            Barcode = dto.Barcode,
            Amount = 0,
            MeasurmentType = dto.MeasurmentType switch
            {
                MeasurmentType.Dona => MeasurmentType.Dona,
                MeasurmentType.Kilogram => MeasurmentType.Kilogram,
                MeasurmentType.Litr => MeasurmentType.Litr,
                MeasurmentType.Metr => MeasurmentType.Metr,
                MeasurmentType.Boshqa => MeasurmentType.Boshqa
            },
            CategoryId = dto.CategoryId,
            LastModifiedDate = LocalTime.GetUtc5Time(),
            Category = null
        };
}
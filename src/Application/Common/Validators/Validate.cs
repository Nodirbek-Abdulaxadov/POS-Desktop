using POS.Application.Common.DataTransferObjects.ProductDtos;
using POS.Domain.Entities;

namespace POS.Application.Common.Validators;
public static class Validate
{
    public static bool IsNullOrEmpty(this string value)
       => string.IsNullOrEmpty(value);

    public static bool IsEqual(this Product product, AddProductDto dto)
    {
        if (dto == null || product == null)
        {
            return false;
        }

        return dto.Name == product.Name &&
               dto.Description == product.Description &&
               dto.CategoryId == product.CategoryId &&
               dto.Barcode == product.Barcode;
    }

    // product validation
    public static bool IsValid(this AddProductDto dto)
        => dto != null
            && !dto.Name.IsNullOrEmpty()
            && !dto.Barcode.IsNullOrEmpty();

    public static bool IsValid(this UpdateProductDto dto)
       => dto != null
           && dto.Id > 0
           && !dto.Name.IsNullOrEmpty()
           && !dto.Barcode.IsNullOrEmpty();
}
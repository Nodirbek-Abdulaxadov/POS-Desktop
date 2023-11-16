using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Common.DataTransferObjects.ProductDtos;
using POS.Application.Common.Models;

namespace POS.Application.Interfaces;

public interface IProductService
{
    Task<PagedList<ProductDto>> GetProductsAsync(int pageSize, int pageNumber);
    Task<PagedList<ProductDto>> GetArchivedProductsAsync(int pageSize, int pageNumber);

    Task<IEnumerable<ProductDto>> GetAllAsync();
    Task<IEnumerable<ProductDto>> GetAllArchivesAsync(int selectedCategoryId);
    Task<IEnumerable<ProductDto>> GetAllActivesAsync(int selectedCategoryId);

    Task<ProductDto> GetByIdAsync(int id);
    Task<ProductDto> AddAsync(AddProductDto dto);

    Task<ProductDto> UpdateAsync(UpdateProductDto dto);
    Task ActionAsync(int id, ActionType action);

    Task<string> GenerateBarcodeAsync();
}

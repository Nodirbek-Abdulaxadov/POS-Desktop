using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Common.Models;

namespace POS.Application.Interfaces;

public interface ICategoryService : IDisposable
{
    Task<PagedList<CategoryDto>> GetCategoriesAsync(int pageSize, int pageNumber);
    Task<PagedList<CategoryDto>> GetArchivedCategoriesAsync(int pageSize, int pageNumber);
    Task<List<CategoryDto>> GetAllAsync();

    Task<CategoryDto> GetByIdAsync(int id);
    Task<CategoryDto> AddAsync(AddCategoryDto dto);

    Task<CategoryDto> UpdateAsync(UpdateCategoryDto dto);
    Task ActionAsync(int id, ActionType action);
}
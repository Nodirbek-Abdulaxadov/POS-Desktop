using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Common.Enums;
using POS.Application.Common.Models;

namespace POS.Application.Interfaces;

public interface ICategoryService : IDisposable
{
    Task<PagedList<CategoryDto>> GetCategoriesAsync(int pageSize, int pageNumber);
    Task<PagedList<CategoryDto>> GetArchivedCategoriesAsync(int pageSize, int pageNumber);
    Task<List<CategoryDto>> GetAllAsync();
    Task<List<CategoryDto>> GetAllArchivesAsync();
    Task<List<CategoryDto>> GetAllActivesAsync();
    Task<List<CategoryDto>> FilterByNameAsync(string text, State state);
    

    Task<CategoryDto> GetByIdAsync(int id);
    Task<CategoryDto> AddAsync(AddCategoryDto dto);
    Task DeleteAsync(int id);
    Task<CategoryDto> UpdateAsync(UpdateCategoryDto dto);
    Task ActionAsync(int id, ActionType action);
}
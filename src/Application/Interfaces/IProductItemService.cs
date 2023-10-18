using BLL.Dtos.WarehouseItemDtos;
using POS.Application.Common.Models;

namespace POS.Application.Interfaces;

public interface IProductItemService
{
    Task<PagedList<ProductItemDto>> GetPagedAsync(int pageSize, int pageNumber, int warehouseId);
    Task<PagedList<ProductItemDto>> GetArchivedAsync(int pageSize, int pageNumber);
    Task<IEnumerable<ProductItemDto>> GetAllAsync();

    Task<ProductItemDto> GetByIdAsync(int id);
    Task<ProductItemDto> AddAsync(AddProductItemDto dto);

    Task<ProductItemDto> Update(UpdateWarehouseItemDto dto);
    Task ActionAsync(int id, ActionType action);
}

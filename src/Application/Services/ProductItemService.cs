using POS.Application.Common.DataTransferObjects.WarehouseItemDtos;
using POS.Application.Common.Models;
using POS.Application.Interfaces;
using POS.Domain.Entities;
using POS.Domain.Interfaces;

namespace POS.Application.Services;

public class ProductItemService : IProductItemService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductItemService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task ActionAsync(int id, ActionType action)
    {
        var model = await _unitOfWork.ProductItems.GetByIdAsync(id);

        if (model == null)
        {
            throw new ArgumentNullException(nameof(model));
        }

        switch (action)
        {
            case ActionType.Archive:
                {
                    model.IsDeleted = true;

                    await _unitOfWork.ProductItems.UpdateAsync(model);
                }
                break;
            case ActionType.Recover:
                {
                    model.IsDeleted = false;
                    await _unitOfWork.ProductItems.UpdateAsync(model);
                }
                break;
            case ActionType.Remove:
                {
                    await _unitOfWork.ProductItems.RemoveAsync(model);
                }
                break;
        }
    }

    /// <summary>
    /// Create new ProductItem
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>New Warehouse item</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="Exception"></exception>
    public async Task<ProductItemDto> AddAsync(AddProductItemDto dto)
    {
        if (dto == null)
        {
            throw new ArgumentNullException(nameof(dto));
        }

        if (dto.BuyingPrice <= 0 || dto.SellingPrice <= 0 || dto.Amount <= 0)
        {
            throw new Exception("All fields must be positive numbers!");
        }

        var existProductItems = (await _unitOfWork.ProductItems.GetAllAsync())
                                        .Where(i => i.ProductId == dto.ProductId
                                                 && i.IsDeleted == false);

        if (existProductItems.Any())
        {
            foreach (var item in existProductItems)
            {
                var price = dto.SellingPrice > item.SellingPrice ? dto.SellingPrice : item.SellingPrice;
            }
        }
        var product = await _unitOfWork.Products.GetByIdAsync(dto.ProductId);
        if (product == null)
        {
            throw new Exception(nameof(product));
        }
        product.Amount = (await _unitOfWork.ProductItems.GetAllAsync())
                                .Where(i => i.IsDeleted == false
                                         && i.ProductId == dto.ProductId)
                                .Sum(p => p.Amount) + dto.Amount;
        await _unitOfWork.Products.UpdateAsync(product);
        var model = await _unitOfWork.ProductItems.AddAsync((ProductItem)dto);
        return (ProductItemDto)model;
    }

    public async Task<List<ProductItemDto>> GetAllAsync()
    {
        var list = await _unitOfWork.ProductItems.GetAllWithProductAsync();
        return list.Select(i => (ProductItemDto)i)
                   .ToList();
    }

    public Task<PagedList<ProductItemDto>> GetArchivedAsync(int pageSize, int pageNumber)
    {
        throw new NotImplementedException();
    }

    public Task<ProductItemDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<PagedList<ProductItemDto>> GetPagedAsync(int pageSize, int pageNumber, int warehouseId)
    {
        throw new NotImplementedException();
    }

    public Task<ProductItemDto> Update(UpdateWarehouseItemDto dto)
    {
        throw new NotImplementedException();
    }
}
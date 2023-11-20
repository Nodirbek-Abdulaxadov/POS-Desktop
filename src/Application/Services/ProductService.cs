
using POS.Application.Common.DataTransferObjects.ProductDtos;
using POS.Application.Common.Enums;
using POS.Application.Common.Exceptions;
using POS.Application.Common.Models;
using POS.Application.Common.Validators;
using POS.Application.Interfaces;
using POS.Domain.Entities;
using POS.Domain.Interfaces;

namespace POS.Application.Services;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task ActionAsync(int id, ActionType action)
    {
        var model = await _unitOfWork.Products.GetByIdAsync(id);

        if (model == null)
        {
            throw new ArgumentNullException(nameof(model));
        }

        switch (action)
        {
            case ActionType.Archive:
                {
                    model.IsDeleted = true;

                    await _unitOfWork.Products.UpdateAsync(model);
                }
                break;
            case ActionType.Recover:
                {
                    model.IsDeleted = false;
                    await _unitOfWork.Products.UpdateAsync(model);
                }
                break;
            case ActionType.Remove:
                {
                    await _unitOfWork.Products.RemoveAsync(model);
                }
                break;
        }
    }

    /// <summary>
    /// Add new product method
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>New product model</returns>
    /// <exception cref="Exception"></exception>
    public async Task<ProductDto> AddAsync(AddProductDto dto)
    {
        if (!dto.IsValid())
        {
            throw new MarketException("Mahsulot nomini ko'rsating!");
        }

        var products = await _unitOfWork.Products.GetAllAsync();
        var barcodes = products.Select(p => p.Barcode).ToList();
        var exist = products.Where(x => x.Name == dto.Name)
                            .Any(p => p.IsEqual(dto));

        if (exist)
        {
            throw new MarketException("Bu mahsulot omborda mavjud!");
        }

        if (barcodes.Any(b => b == dto.Barcode) &&
            !string.IsNullOrEmpty(dto.Barcode))
        {
            throw new MarketException("Bu barcode avval ro'yxatga olingan!");
        }

        var model = await _unitOfWork.Products.AddAsync((Product)dto);

        return (ProductDto)model;
    }

    public async Task<string> GenerateBarcodeAsync()
    {
        var products = await _unitOfWork.Products.GetAllAsync();
        var barcodes = products.Select(p => p.Barcode).ToList();
        Random random = new();
        goBack: var randomBarcode = random.NextInt64(1000000000000, 9999999999999);
        if (barcodes.Any(b => b == randomBarcode.ToString()))
        {
            goto goBack;
        }

        return randomBarcode.ToString();
    }

    /// <summary>
    /// Barcha productlarni olish
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<ProductDto>> GetAllAsync()
    {
        var list = await _unitOfWork.Products.GetAllWithCategories();
        return list.Select(p => (ProductDto)p);
    }

    /// <summary>
    /// Activ productlarni olish 
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<ProductDto>> GetAllActivesAsync(int selectedCategoryId)
    {
        var list = await _unitOfWork.Products.GetAllWithCategories();

        if (selectedCategoryId != 0)
        {
            list = list.Where(p => p.CategoryId == selectedCategoryId).ToList();
        }

        var dtoList = list.Where(p => p.IsDeleted == false)
                          .Select(x => (ProductDto)x);
        return dtoList.ToList();
    }
    /// <summary>
    /// Arxivlangan productlarni olish 
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<ProductDto>> GetAllArchivesAsync(int selectedCategoryId)
    {
        var list = await _unitOfWork.Products.GetAllWithCategories();

        if (selectedCategoryId != 0)
        {
            list = list.Where(p => p.CategoryId == selectedCategoryId).ToList();
        }

        var dtoList = list.Where(p => p.IsDeleted == true)
                           .Select(x => (ProductDto)x);
        return dtoList.ToList();
    }

    public Task<PagedList<ProductDto>> GetArchivedProductsAsync(int pageSize, int pageNumber)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<PagedList<ProductDto>> GetProductsAsync(int pageSize, int pageNumber)
    {
        throw new NotImplementedException();
    }


    public Task<ProductDto> UpdateAsync(UpdateProductDto dto)
    {
        throw new NotImplementedException();
    }



    public async Task<List<ProductDto>> FilterByNameAsync(string text, State state, int selectedCategoryId)
    {
        var list = state switch
        {
            State.Active => await GetAllActivesAsync(selectedCategoryId),
            State.Archive => await GetAllArchivesAsync(selectedCategoryId),
            _ => await GetAllAsync(),
        };
      
        return list.Where(x => x.Name.ToLower()
                             .Contains(text.ToLower()))
                             .ToList();
    }
}
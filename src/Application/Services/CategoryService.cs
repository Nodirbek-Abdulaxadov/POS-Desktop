using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Common.Models;
using POS.Application.Interfaces;
using POS.Domain.Entities;
using POS.Domain.Interfaces;

namespace POS.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task ActionAsync(int id, ActionType action)
    {
        var model = await _unitOfWork.Categories.GetByIdAsync(id);

        if (model == null)
        {
            throw new ArgumentNullException(nameof(model));
        }

        switch (action)
        {
            case ActionType.Archive:
                {
                    model.IsDeleted = true;

                    await _unitOfWork.Categories.UpdateAsync(model);
                }
                break;
            case ActionType.Recover:
                {
                    model.IsDeleted = false;
                    await _unitOfWork.Categories.UpdateAsync(model);
                }
                break;
            case ActionType.Remove:
                {
                    await _unitOfWork.Categories.RemoveAsync(model);
                }
                break;
        }

        await _unitOfWork.SaveAsync();
    }

    public async Task<CategoryDto> AddAsync(AddCategoryDto dto)
    {
        if (dto == null)
        {
            throw new ArgumentNullException(nameof(dto));
        }

        if (string.IsNullOrEmpty(dto.Name))
        {
            throw new ArgumentNullException(nameof(dto.Name));
        }

        var list = await GetAllAsync();
        if (list.Any(x => x.Name == dto.Name))
        {
            throw new Exception("This category name is already exist!");
        }

        var model = await _unitOfWork.Categories.AddAsync((Category)dto);
        await _unitOfWork.SaveAsync();

        return (CategoryDto)model;
    }

    public async Task<List<CategoryDto>> GetAllAsync()
    {
        var list = await _unitOfWork.Categories.GetAllAsync();

        var dtoList = list.Select(x => (CategoryDto)x);
        return dtoList.ToList();
    }

    public async Task<PagedList<CategoryDto>> GetArchivedCategoriesAsync(int pageSize, int pageNumber)
    {
        var dtoList = (await _unitOfWork.Categories.GetAllAsync())
                                                   .Where(w => w.IsDeleted == true)
                                                   .Select(i => (CategoryDto)i)
                                                   .ToList();

        if (dtoList.Count == 0)
        {
            throw new Exception("Empty list");
        }

        PagedList<CategoryDto> pagedList = new(dtoList.ToList(),
                                                     dtoList.Count(),
                                                     pageSize, pageNumber);

        if (pageNumber > pagedList.TotalPages || pageNumber < 1)
        {
            throw new ArgumentNullException("Page not fount!");
        }

        return pagedList.ToPagedList(dtoList, pageSize, pageNumber);
    }

    public async Task<CategoryDto> GetByIdAsync(int id)
    {
        var warehouse = await _unitOfWork.Categories.GetByIdAsync(id);
        if (warehouse == null)
        {
            throw new ArgumentNullException(nameof(warehouse));
        }

        return (CategoryDto)warehouse;
    }

    public async Task<PagedList<CategoryDto>> GetCategoriesAsync(int pageSize, int pageNumber)
    {
        var dtoList = (await _unitOfWork.Categories.GetAllAsync())
                                                   .Where(w => w.IsDeleted == false)
                                                   .Select(i => (CategoryDto)i)
                                                   .OrderByDescending(i => i.Id)
                                                   .ToList();
        if (dtoList.Count == 0)
        {
            throw new Exception("Empty list");
        }

        PagedList<CategoryDto> pagedList = new(dtoList.ToList(),
                                                     dtoList.Count(),
                                                     pageSize, pageNumber);

        if (pageNumber > pagedList.TotalPages || pageNumber < 1)
        {
            throw new ArgumentNullException("Page not fount!");
        }

        return pagedList.ToPagedList(dtoList, pageSize, pageNumber);
    }

    public async Task<CategoryDto> UpdateAsync(UpdateCategoryDto dto)
    {
        if (dto == null)
        {
            throw new ArgumentNullException(nameof(dto));
        }

        if (string.IsNullOrEmpty(dto.Name))
        {
            throw new ArgumentNullException(nameof(dto.Name));
        }

        var model = await _unitOfWork.Categories.GetByIdAsync(dto.Id);

        if (model == null)
        {
            throw new Exception("Category is not found!");
        }

        model = (Category)dto;
        await _unitOfWork.Categories.UpdateAsync(model);
        await _unitOfWork.SaveAsync();

        var res = await GetByIdAsync(dto.Id);
        return res;
    }
}
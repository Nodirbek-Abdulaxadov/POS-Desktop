﻿using POS.Domain.Entities;

namespace POS.Domain.Interfaces;

public interface IProductInterface : IRepository<Product>
{
    Task<List<Product>> GetAllWithCategories();
}
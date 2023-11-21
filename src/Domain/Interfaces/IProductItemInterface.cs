using POS.Domain.Entities;

namespace POS.Domain.Interfaces;
public interface IProductItemInterface : IRepository<ProductItem>
{
    Task<IEnumerable<ProductItem>> GetAllWithProductAsync();
}
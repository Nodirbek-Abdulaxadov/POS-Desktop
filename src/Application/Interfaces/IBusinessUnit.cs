namespace POS.Application.Interfaces;
public interface IBusinessUnit
{
    IAuthService AuthService { get; }
    ICategoryService CategoryService { get; }
    IProductService ProductService { get; }
    IProductItemService ProductItemService { get; }
    IReceiptService ReceiptService { get; }
}
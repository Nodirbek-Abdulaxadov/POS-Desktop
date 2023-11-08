using POS.Application.Interfaces;

namespace POS.Application.Services;
public class BusinessUnit : IBusinessUnit
{
    public BusinessUnit(IAuthService authService,
                           ICategoryService categoryService,
                           IProductItemService productItemService,
                           IProductService productService,
                           IReceiptService receiptService)
    {
        AuthService = authService;
        CategoryService = categoryService;
        ProductItemService = productItemService;
        ProductService = productService;
        ReceiptService = receiptService;
    }

    public IAuthService AuthService { get; }

    public ICategoryService CategoryService { get; }

    public IProductService ProductService { get; }

    public IProductItemService ProductItemService { get; }

    public IReceiptService ReceiptService { get; }
}
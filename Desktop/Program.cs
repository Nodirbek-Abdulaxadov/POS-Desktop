using DataLayer.Repositories;
using Desktop.Admin;
using Desktop.Admin.CategoryForms;
using Desktop.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Interfaces;
using POS.Application.Services;
using POS.Domain.DataContext;
using POS.Domain.Interfaces;
using POS.Domain.Repositories;

namespace Desktop;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var services = new ServiceCollection();

        ConfigureServices(services);

        var serviceProvider = services.BuildServiceProvider();

        var form1 = serviceProvider.GetRequiredService<AdminForm>();
        Application.Run(form1);
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=PosDB;";
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString, o => o.EnableRetryOnFailure()), ServiceLifetime.Transient, ServiceLifetime.Transient);

        services.AddTransient<ICategoryInterface, CategoryRepository>();
        services.AddTransient<IProductInterface, ProductRepository>();
        services.AddTransient<IProductItemInterface, ProductItemRepository>();
        services.AddTransient<IReceiptInterface, ReceiptRepository>();
        services.AddTransient<ITransactionInterface, TransactionRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddTransient<ICategoryService, CategoryService>();
        services.AddTransient<IProductService, ProductService>();
        services.AddTransient<IProductItemService, ProductItemService>();
        services.AddTransient<IReceiptService, ReceiptService>();
        services.AddTransient<IUserInterface, UserRepository>();
        services.AddTransient<IAuthService, AuthService>();
        services.AddTransient<IBusinessUnit, BusinessUnit>();

        services.AddScoped<StartForm>();
        services.AddScoped<Login>();
        services.AddScoped<AdminForm>();
        services.AddScoped<AddCategoryForm>();
    }

}
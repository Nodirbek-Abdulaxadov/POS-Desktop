using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Interfaces;
using POS.Application.Services;
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

        using var serviceProvider = services.BuildServiceProvider();
        var form1 = serviceProvider.GetRequiredService<StartForm>();
        Application.Run(form1);
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=PosDB;";
        services.AddScoped<StartForm>();
        services.AddDbContext<POS.Domain.DataContext.ApplicationContext>(options => 
            options.UseSqlServer(connectionString));

        services.AddScoped<ICategoryInterface, CategoryRepository>();
        services.AddScoped<IProductInterface, ProductRepository>();
        services.AddScoped<IProductItemInterface, ProductItemRepository>();
        services.AddScoped<IReceiptInterface, ReceiptRepository>();
        services.AddScoped<ITransactionInterface, TransactionRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IProductItemService, ProductItemService>();
        services.AddScoped<IReceiptService, ReceiptService>();
    }
}
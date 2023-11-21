using DataLayer.Repositories;
using Desktop.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Interfaces;
using POS.Application.Services;
using POS.Domain.Interfaces;
using POS.Domain.Repositories;

namespace Desktop;
public static class Configuration
{
    public static IServiceProvider GetServiceProvider()
    {
        var services = new ServiceCollection();

        ConfigureServices(services);

        return services.BuildServiceProvider();
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=PosDB;";
        services.AddDbContext<POS.Domain.DataContext.ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString, o => o.EnableRetryOnFailure());
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }, ServiceLifetime.Transient, ServiceLifetime.Transient);

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
    }
}

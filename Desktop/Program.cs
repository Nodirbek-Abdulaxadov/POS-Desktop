using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Domain.Interfaces;

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
        var form1 = serviceProvider.GetRequiredService<Form1>();
        Application.Run(form1);
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        services.AddScoped<Form1>().AddDbContext<DbContext>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
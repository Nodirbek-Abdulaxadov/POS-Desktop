using Microsoft.Extensions.DependencyInjection;
using POS.Application.Common.Enums;
using POS.Application.Interfaces;

namespace Desktop.Admin.ProductItemForms;
public partial class ProductItemTable : UserControl
{
    private IBusinessUnit _businessUnit;
    private State _selectedState = State.All;
    public ProductItemTable(IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _businessUnit = businessUnit;
    }

    private async void ProductItemTable_Load(object sender, EventArgs e)
    {
        await Task.Run(() => FillProductItems(_selectedState));
    }

    /// <summary>
    /// Fill table with categories
    /// </summary>
    /// <returns></returns>
    private async Task FillProductItems(State selected)
    {
        _businessUnit = Configuration.GetServiceProvider()
                                 .GetRequiredService<IBusinessUnit>();
        var list = await _businessUnit.ProductItemService.GetAllAsync();
        //selected switch
        //{
        //    State.Active => await _businessUnit.ProductItemService.GetAllAsync(),
        //    State.Archive => await _businessUnit.ProductService.GetAllAsync(),
        //    State.All => throw new NotImplementedException(),
        //    _ => await _businessUnit.ProductService.GetAllAsync()
        //};

        if (IsHandleCreated)
        {
            table.BeginInvoke(() =>
            {
                table.DataSource = list.Select(i =>
                new
                {
                    Id = i.Id,
                    Mahsulot = i.ProductName,
                    Miqdori = i.Amount,
                    Olish_Narxi = i.BuyingPrice,
                    Sotish_Narxi = i.SellingPrice,
                    Sana = i.AddedDate
                }).ToList();
            });
        }
    }
}

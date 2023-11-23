using System.Data;
using Desktop.Extended;
using POS.Application.Common.DataTransferObjects.ProductDtos;
using POS.Application.Common.DataTransferObjects.WarehouseItemDtos;
using POS.Application.Common.Exceptions;
using POS.Application.Interfaces;

namespace Desktop.Admin.ProductItemForms;
public partial class AddProductItemForm : Form
{
    private readonly IBusinessUnit _businessUnit;
    public List<ProductItemDto> _productItems;
    public List<ProductDto> Products { get; set; }

    public AddProductItemForm(IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _businessUnit = businessUnit;
    }



    private void CanselBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }




    private async void Save_btn_Click_1(object sender, EventArgs e)
    {
        _productItems = await _businessUnit.ProductItemService.GetAllAsync();

        AddProductItemDto dto = new AddProductItemDto()
        {
            ProductId = _productItems.FirstOrDefault(x => x.ProductName == mahsulotlar.Text).ProductId,
            Amount = decimal.Parse(Miqdori.Text),
            BuyingPrice = decimal.Parse(Outcame_price.Text),
            SellingPrice = decimal.Parse(Income_price.Text),
            BroughtDate = DateTime.Parse(Income_date.Text),
        };
        try
        {
            await Task.Run(async () =>
            {
                await _businessUnit.ProductItemService
                                   .AddAsync(dto);
            });
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (MarketException ex)
        {
            new Toastr().ShowError(ex.ErrorMessage);
        }
        catch (Exception ex)
        {
            new Toastr().ShowError(ex.Message);
        }
    }

    private async void AddProductItemForm_Load(object sender, EventArgs e)
    {
        var _productItems = await _businessUnit.ProductService
                        .GetAllAsync();
        mahsulotlar.DataSource = _productItems.Select(x => x.Name)
                                         .ToArray();
    }
}
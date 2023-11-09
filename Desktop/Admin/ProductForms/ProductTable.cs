using Desktop.Extended;
using POS.Application.Interfaces;

namespace Desktop.Admin.ProductForms;
public partial class ProductTable : UserControl
{
    private readonly IBusinessUnit _businessUnit;

    public ProductTable(IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _businessUnit = businessUnit;
    }

    private async void addbtn_Click(object sender, EventArgs e)
    {
        AddProductForm form = new(_businessUnit);
        var result = form.ShowDialog();
        if (result == DialogResult.OK)
        {
            new Toastr().ShowSuccess();
            await Task.Run(FillProducts);
        }
    }

    private void editbtn_Click(object sender, EventArgs e)
    {

    }

    private void deletebtn_Click(object sender, EventArgs e)
    {

    }

    private void table_CellClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private async void ProductTable_Load(object sender, EventArgs e)
    {
        await Task.Run(FillProducts);
    }

    /// <summary>
    /// Fill table with categories
    /// </summary>
    /// <returns></returns>
    private async Task FillProducts()
    {
        var list = await _businessUnit.ProductService.GetAllAsync();
        table.BeginInvoke(() =>
        {
            table.DataSource = list.Select(i =>
            new 
            { 
                Kodi = i.Barcode, 
                Nomi = i.Name,
                Miqdori = i.Amount,
                OlchovTuri = i.MeasurmentType.ToString(),
                Izoh = i.Description,
                Kategoriyasi = i.Category.Name
            }).ToList();
        });
    }
}

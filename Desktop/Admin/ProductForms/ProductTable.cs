using Desktop.Extended;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Common.Models;
using POS.Application.Interfaces;

namespace Desktop.Admin.ProductForms;
public partial class ProductTable : UserControl
{
    private IBusinessUnit _businessUnit;
    private readonly List<int> selectedIds = new();

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

    private async void deletebtn_Click(object sender, EventArgs e)
    {
        _businessUnit = Configuration.GetServiceProvider()
                                     .GetRequiredService<IBusinessUnit>();
        if (selectedIds.Any())
        {
            var result = new Modal($"Tanlangan {selectedIds.Count} ta mahsulot o'chirilsinmi?").ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (var id in selectedIds)
                {
                    await _businessUnit.ProductService.ActionAsync(id, ActionType.Remove);
                }
                new Toastr().ShowSuccess("Muvoffaqqiyatli o'chirildi");
                await Task.Run(FillProducts);
                selectedIds.Clear();
            }
        }
        else
        {
            new Toastr().ShowWarning("Mahsulotlardan birini tanlang!");
        }
    }

    private void table_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        //selectedId = int.Parse(table.SelectedRows[0].Cells[0].Value.ToString());
        selectedIds.Clear();
        foreach (DataGridViewRow row in table.SelectedRows)
        {
            selectedIds.Add(int.Parse(row.Cells[0].Value.ToString()));
        }
    }

    private async void ProductTable_Load(object sender, EventArgs e)
    {
        _businessUnit = Configuration.GetServiceProvider()
                                     .GetRequiredService<IBusinessUnit>();
        await Task.Run(FillProducts);
    }

    /// <summary>
    /// Fill table with categories
    /// </summary>
    /// <returns></returns>
    private async Task FillProducts()
    {
        var list = await _businessUnit.ProductService.GetAllAsync();
        if (IsHandleCreated)
        {
            table.BeginInvoke(() =>
            {
                table.DataSource = list.Select(i =>
                new
                {
                    Id = i.Id,
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
}

using Desktop.Extended;
using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Common.DataTransferObjects.ProductDtos;
using POS.Application.Common.Exceptions;
using POS.Application.Common.Models;
using POS.Application.Interfaces;
using POS.Domain.Enums;

namespace Desktop.Admin.ProductForms;
public partial class AddProductForm : Form
{
    private readonly IBusinessUnit _businessUnit;
    private List<CategoryDto> _categories;

    public AddProductForm(IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _businessUnit = businessUnit;
        this.AcceptButton = guna2Button1;
    }

    /// <summary>
    /// Save product
    /// </summary>
    /// <returns></returns>
    private async Task SaveProduct()
    {
        AddProductDto productDto = new()
        {
            Name = name_textbox.Text,
            Barcode = barcode.Text.Trim() ?? "000000000000",
            WarningAmount = int.Parse(
                    string.IsNullOrEmpty(warningAmount.Text.Trim()) ?
                    "0" : warningAmount.Text.Trim()),
            CategoryId = _categories.FirstOrDefault(x => x.Name == categoryComboBox.Text).Id,
            MeasurmentType = (MeasurmentType)mtype.SelectedItem,
            Description = description.Text
        };

        try
        {
            await Task.Run(async () =>
            {
                await _businessUnit.ProductService
                                   .AddAsync(productDto);
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

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        await SaveProduct();
    }

    private async void AddProductForm_Load(object sender, EventArgs e)
    {
        _categories = await _businessUnit.CategoryService
                                         .GetAllAsync();
        categoryComboBox.DataSource = _categories.Select(x => x.Name)
                                         .ToArray();
        mtype.DataSource = Enum.GetValues(typeof(MeasurmentType));
    }

    private void CanselBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    /// <summary>
    /// Enter orqali saqlash
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void SaveByEnter(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true; // KeyPress eventni oldini olish
            await SaveProduct();
        }
    }

    /// <summary>
    /// Yangi barcodeni olish
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// 

    private async void NewBarcodeBtn_Click(object sender, EventArgs e)
    {

        barcode.Text = await _businessUnit.ProductService.GenerateBarcodeAsync();
    }
    /// <summary>
    /// Scaner orqali barcodeni olish 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ScanerBtn_Click(object sender, EventArgs e)
    {
        if(barcode.Text != string.Empty)
        {
            barcode.Text = string.Empty;
            barcode.Focus();
        }
        else
        {
            barcode.Focus();
        }
    }

    private void name_textbox_TextChanged(object sender, EventArgs e)
    {
        ValidateInput();
    }

    /// <summary>
    /// Enga kamida nechta o'z kiritish kerakligi 
    /// </summary>
    private void ValidateInput()
    {
        if (name_textbox.Text.Length < 3)
        {
            errorMessage.Text = "Kamida 3 ta belgi kiriting";
            errorMessage.Visible = true;
            guna2Button1.Enabled = false;
        }
        else if (name_textbox.Text.Length > 50)
        {
            errorMessage.Text = "Maxsimum 50 ta belgi kiriting";
            errorMessage.Visible = true;
            guna2Button1.Enabled = false;
        }
        else
        {
            errorMessage.Visible = false;
            guna2Button1.Enabled = true;
        }
    }
}

using Desktop.Extended;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Common.Exceptions;
using POS.Application.Interfaces;

namespace Desktop.Admin.CategoryForms;
public partial class AddCategoryForm : Form
{
    private IBusinessUnit _businessUnit;

    public AddCategoryForm(IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _businessUnit = businessUnit;
        this.AcceptButton = guna2Button1;
    }
    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        await SaveCategory();
    }

    private void name_textbox_TextChanged(object sender, EventArgs e)
    {
        ValidateInput();
    }

    private async void guna2Button1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true; // KeyPress eventni oldini olish
            await SaveCategory();
        }
    }

    /// <summary>
    /// Save button click event - save new category
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async Task SaveCategory()
    {
        try
        {
            await Task.Run(async () =>
            {
                _businessUnit = Configuration.GetServiceProvider()
                                                .GetRequiredService<IBusinessUnit>();
                await _businessUnit.CategoryService
                                            .AddAsync(new AddCategoryDto()
                                            {
                                                Name = name_textbox.Text
                                            });
            });
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (MarketException ex)
        {
            new Toastr().ShowError(ex.ErrorMessage);
        }
        catch (Exception)
        {
            new Toastr().ShowError();
        }
    }

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

    private void CanselBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

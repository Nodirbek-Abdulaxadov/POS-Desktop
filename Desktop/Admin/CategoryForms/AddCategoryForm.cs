using Desktop.Extended;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Interfaces;

namespace Desktop.Admin.CategoryForms;
public partial class AddCategoryForm : Form
{
    private IBusinessUnit _businessUnit;

    public AddCategoryForm(IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _businessUnit = businessUnit;
    }

    /// <summary>
    /// Add shadow to form
    /// </summary>
    protected override CreateParams CreateParams
    {
        get
        {
            const int CS_DROPSHADOW = 0x20000;
            CreateParams cp = base.CreateParams;
            cp.ClassStyle |= CS_DROPSHADOW;
            return cp;
        }
    }

    /// <summary>
    /// Close buttton click event - close form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button2_Click(object sender, EventArgs e)
    {
        Close();
    }

    private async void guna2Button1_Click(object sender, EventArgs e)
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
        catch (Exception)
        {
            new Toastr().ShowError();
        }
    }
}

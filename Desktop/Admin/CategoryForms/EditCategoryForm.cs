using Desktop.Extended;
using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Common.Exceptions;
using POS.Application.Interfaces;

namespace Desktop.Admin.CategoryForms;
public partial class EditCategoryForm : Form
{
    private readonly IBusinessUnit _businessUnit;
    private readonly int id = 0; 

    public EditCategoryForm(int id, IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _businessUnit = businessUnit;
        this.id = id;
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
    /// Edit button click event - load selected category to form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void EditCategoryForm_Load(object sender, EventArgs e)
    {
        var categoryDto = await _businessUnit.CategoryService.GetByIdAsync(id);
        name_textbox.Text = categoryDto.Name;
    }

    /// <summary>
    /// save button click event - save changes
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        try
        {
            await Task.Run(async () =>
            {
                await _businessUnit.CategoryService
                                            .UpdateAsync(new UpdateCategoryDto()
                                            {
                                                Id = id,
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

    /// <summary>
    /// close button event - close form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}
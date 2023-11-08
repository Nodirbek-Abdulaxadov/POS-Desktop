using Desktop.Extended;
using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Interfaces;

namespace Desktop.Admin.CategoryForms;
public partial class CategoryTable : UserControl
{
    private readonly List<CategoryDto> _categories = new();
    private readonly IBusinessUnit _businessUnit;
    private int selectedId = 0;

    public CategoryTable(IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _businessUnit = businessUnit;
    }

    /// <summary>
    /// CategoryTable load event - fill table with categories
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void CategoryTable_Load(object sender, EventArgs e)
    {
        await Task.Run(FillCategories);
    }

    /// <summary>
    /// Fill table with categories
    /// </summary>
    /// <returns></returns>
    private async Task FillCategories()
    {
        var list = await _businessUnit.CategoryService.GetAllAsync();
        table.BeginInvoke(() =>
        {
            table.DataSource = list.Select(i =>
            new { Id = i.Id, Nomi = i.Name })
            .ToList();
            _categories.AddRange(list);
        });
    }

    /// <summary>
    /// Add button click event - open AddCategory form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void addbtn_Click(object sender, EventArgs e)
    {
        AddCategoryForm form = new(_businessUnit);
        var result = form.ShowDialog();
        if (result == DialogResult.OK)
        {
            new Toastr().ShowSuccess();
            await Task.Run(FillCategories);
        }
    }

    /// <summary>
    /// Edit button click event - open EditCategory form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void editbtn_Click(object sender, EventArgs e)
    {
        if (selectedId != 0)
        {
            EditCategoryForm form = new(selectedId, _businessUnit);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                new Toastr().ShowSuccess("O'zgarishlar saqlandi!");
                await Task.Run(FillCategories);
                selectedId = 0;
            }
        }
        else
        {
            new Toastr().ShowWarning("Kategoriyalardan birini tanlang!");
        }
    }

    /// <summary>
    /// Delete button click event - delete selected category
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void deletebtn_Click(object sender, EventArgs e)
    {
        if (selectedId != 0)
        {
            var result = new Modal().ShowDialog();
            if (result == DialogResult.OK)
            {
                await _businessUnit.CategoryService.DeleteAsync(selectedId);
                new Toastr().ShowSuccess("Muvoffaqqiyatli o'chirildi");
                await Task.Run(FillCategories);
                selectedId = 0;
            }
        }
        else
        {
            new Toastr().ShowWarning("Kategoriyalardan birini tanlang!");
        }
    }

    /// <summary>
    /// select category id
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void table_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        selectedId = int.Parse(table.SelectedRows[0].Cells[0].Value.ToString());
    }
}

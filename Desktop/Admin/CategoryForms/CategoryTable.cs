using System.Windows.Forms;
using Desktop.Extended;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Common.Models;
using POS.Application.Interfaces;
using POS.Domain.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace Desktop.Admin.CategoryForms;
public partial class CategoryTable : UserControl
{
    private readonly List<CategoryDto> _categories = new();
    private IBusinessUnit _businessUnit;
    private int SelectInfoCategory = 0;
    private List<string> infCt = new()
    {  
        "Barchasi",
        "Activlar",
        "Arxivlar"
    };
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
        _businessUnit = Configuration.GetServiceProvider()
                                     .GetRequiredService<IBusinessUnit>();
        InfoCategory.DataSource = infCt.ToArray();
    }

    /// <summary>
    /// Fill table with categories
    /// </summary>
    /// <returns></returns>
    private async Task FillCategoriesForActive()
    {
        var list = await _businessUnit.CategoryService.GetAllAsync();
        if (IsHandleCreated)
        {
            table.BeginInvoke(() =>
            {
                table.DataSource = list.Where(i => i.IsDeleted == false).Select(i =>
                new { Id = i.Id, Nomi = i.Name })
                .ToList();
                _categories.AddRange(list);
            });
        }
    }

    private async Task FillCategoriesForArchives()
    {
        var list = await _businessUnit.CategoryService.GetAllAsync();
        if (IsHandleCreated)
        {
            table.BeginInvoke(() =>
            {
                table.DataSource = list.Where(i => i.IsDeleted == true).Select(i =>
                new { Id = i.Id, Nomi = i.Name })
                .ToList();
                _categories.AddRange(list);
            });
        }
    }

    private async Task FillCategories()
    {
        var list = await _businessUnit.CategoryService.GetAllAsync();
        if (IsHandleCreated)
        {
            table.BeginInvoke(() =>
            {
                table.DataSource = list.Select(i =>
                new { Id = i.Id, Nomi = i.Name })
                .ToList();
                _categories.AddRange(list);
            });
        }
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
                try
                {
                    await _businessUnit.CategoryService.DeleteAsync(selectedId);
                    new Toastr().ShowSuccess("Muvoffaqqiyatli o'chirildi");
                }
                catch (DbUpdateException)
                {
                    new Toastr().ShowError("Kategoriyaga tegishli mahsulotlar mavjud!");
                }
                catch (Exception)
                {
                    new Toastr().ShowError("Xatolik yuz berdi!");
                }
                finally
                {
                    await Task.Run(FillCategories);
                    selectedId = 0;
                }
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


    private void search_textbox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (!string.IsNullOrEmpty(search_textbox.Text))
            {
                var searchResult = _categories.Where(i => i.Name.ToLower()
                                              .Contains(search_textbox.Text.ToLower()))
                                              .Select(i => new { Id = i.Id, Nomi = i.Name })
                                              .ToList();

                if (searchResult != null && searchResult.Any())
                {
                    table.DataSource = searchResult;
                }
                else
                {
                    table.DataSource = new List<CategoryDto>();
                    new Toastr().ShowError("Bunday kategoriya mavjud emas");
                }
            }
            else
            {
                table.DataSource = _categories ?? new List<CategoryDto>();
            }
        }
        catch (Exception)
        {
            new Toastr().ShowError("Xatolik yuz berdi");
        }
    }

    private async void ArchiveBtn_Click(object sender, EventArgs e)
    {
        if (selectedId != 0)
        {
            try
            {
                var result = new Modal("Rostdan ham arxivlamoqchimisiz?").ShowDialog();
                if (result == DialogResult.OK)
                {
                    await _businessUnit.CategoryService.ActionAsync(selectedId, ActionType.Archive);
                    await Task.Run(FillCategories);
                    new Toastr().ShowSuccess("Muvoffaqqiyatli arxivelandi");
                }
                else
                {
                    // Handle cancel or other cases if needed
                }
            }
            catch (Exception)
            {
                new Toastr().ShowError("Arxivelashda hatolik yuz berdi");
            }
        }
        else
        {
            new Toastr().ShowError("Arxivelash uchun kategoriyalardan birini tanlang!");
        }
    }

    private async void InfoCategory_SelectedIndexChangedAsync(object sender, EventArgs e)
    {
        var tmp = InfoCategory.Text.ToString();
        if (tmp == "Activlar")
        {
            SelectInfoCategory = 0;
            table.DataSource = FillCategoriesForActive();
            //await Task.Run(FillCategoriesForActive);
        }

        else if (tmp == "Arxivlar")
        {
            SelectInfoCategory = 1;
            table.DataSource = FillCategoriesForArchives();
            //await Task.Run(FillCategoriesForArchives);
        }

        else
        {
            SelectInfoCategory = 2;
            table.DataSource = FillCategoriesForArchives();
            //await Task.Run(FillCategories);
        }
    }

}
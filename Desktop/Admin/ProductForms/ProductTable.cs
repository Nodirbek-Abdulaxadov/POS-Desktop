using Desktop.Extended;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Common.DataTransferObjects.ProductDtos;
using POS.Application.Common.Enums;
using POS.Application.Common.Models;
using POS.Application.Interfaces;
using POS.Domain.Entities;

namespace Desktop.Admin.ProductForms;
public partial class ProductTable : UserControl
{
    private IBusinessUnit _businessUnit;
    private List<CategoryDto> _categories;
    private List<ProductDto> _products;
    private int selectedId = 0;
    private State selected = State.All;
    private int selectedCategoryId = 0;

    public ProductTable(IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _businessUnit = businessUnit;
        ProductCategoryComboBox.SelectedIndex = 0;
    }

    private async void addbtn_Click(object sender, EventArgs e)
    {
        AddProductForm form = new(_businessUnit);
        var result = form.ShowDialog();
        if (result == DialogResult.OK)
        {
            new Toastr().ShowSuccess();
            await Task.Run(() => FillProducts(selected));
        }
    }

    private void editbtn_Click(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Mahsulotlarni o'chirish 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void deletebtn_Click(object sender, EventArgs e)
    {
        _businessUnit = Configuration.GetServiceProvider()
                                     .GetRequiredService<IBusinessUnit>();
        if (selectedId != 0)
        {
            var result = new Modal().ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    await _businessUnit.ProductService.ActionAsync(selectedId, ActionType.Remove);
                    new Toastr().ShowSuccess("Muvoffaqqiyatli o'chirildi");
                }

                catch (Exception)
                {
                    new Toastr().ShowError("Xatolik yuz berdi!");
                }
                finally
                {
                    await Task.Run(() => FillProducts(selected));
                    selectedId = 0;
                }
            }
        }
        else
        {
            new Toastr().ShowWarning("Mahsulotlardan birini tanlang!");
        }
    }

    private void table_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        selectedId = int.Parse(table.SelectedRows[0].Cells[0].Value.ToString());


    }



    /// <summary>
    /// Fill table with categories
    /// </summary>
    /// <returns></returns>
    private async Task FillProducts(State selected)
    {
        _businessUnit = Configuration.GetServiceProvider()
                                 .GetRequiredService<IBusinessUnit>();
        var list = selected switch
        {
            State.Active => await _businessUnit.ProductService.GetAllActivesAsync(selectedCategoryId),
            State.Archive => await _businessUnit.ProductService.GetAllArchivesAsync(selectedCategoryId),
            State.All => await _businessUnit.ProductService.GetAllAsync()
        };

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

    /// <summary>
    /// ProductTable_Load Yuklanganda ComboBoxga barcha categoriyalarni olib kelish 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void ProductTable_Load(object sender, EventArgs e)
    {
        _businessUnit = Configuration.GetServiceProvider()
                                     .GetRequiredService<IBusinessUnit>();
        await Task.Run(() => FillProducts(selected));
        _categories = await _businessUnit.CategoryService
                         .GetAllAsync();


        var AllCategoryOfComboBox = new List<string> { "Barcha kategoriyalar" };
        AllCategoryOfComboBox.AddRange(_categories.Select(c => c.Name));
        FilterComboBox.DataSource = AllCategoryOfComboBox.ToArray();
    }

    /// <summary>
    /// Barcha tanlangan categoriyalardagi maxsulotlarni olish 
    /// </summary>
    /// <param name="selectedCategoryName"></param>
    /// <returns></returns>
    private async Task FillProductSelectetCategory(string selectedCategoryName)
    {
        try
        {
            var list = await _businessUnit.ProductService.GetAllAsync();
            var selectedList = list.Where(i => i.Category.Name == selectedCategoryName).ToList();


            table.BeginInvoke(() =>
            {
                table.DataSource = selectedList.Select(i => new
                {
                    Id = i.Id,
                    Kodi = i.Barcode,
                    Nomi = i.Name,
                    Miqdori = i.Amount,
                    OlchovTuri = i.MeasurmentType.ToString(),
                    Izoh = i.Description,
                    Kategoriyasi = i.Category.Name,
                }).ToList();
            });
        }
        catch (Exception)
        {
            new Toastr().ShowError("Xato yuz berdi. Iltimos, qayta urinib ko'ring.");
        }

    }

    /// <summary>
    /// ComboBox orqali formani chaqirish 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

        try
        {
            string selectedCategoryName = FilterComboBox.SelectedItem.ToString();

            if (selectedCategoryName == "Barcha kategoriyalar")
            {
                await FillProducts(selected);
                selectedCategoryId = 0;
            }
            else if (!string.IsNullOrEmpty(selectedCategoryName))
            {
                var category = _categories.FirstOrDefault(c => c.Name == selectedCategoryName);
                selectedCategoryId = category.Id;
                await FillProductSelectetCategory(selectedCategoryName);
            }
        }
        catch (Exception)
        {
            new Toastr().ShowError("Xatolik yuz berdi! Iltimos, qayta urinib ko'ring.");

        }
    }

    /// <summary>
    /// Arxivlash 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void ArchiveBtn_Click(object sender, EventArgs e)
    {
        if (selectedId != 0)
        {
            try
            {
                if (selected == State.Active || selected == State.All)
                {

                    ArchiveBtn.Text = "Arxivlash";
                    var result = new Modal("Rostdan ham arxivlamoqchimisiz?").ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        await _businessUnit.ProductService.ActionAsync(selectedId, ActionType.Archive);
                        await Task.Run(() => FillProducts(selected));
                        new Toastr().ShowSuccess("Muvoffaqqiyatli arxivelandi");
                    }
                }
                else
                {
                    if (selectedId != 0)
                    {
                        ArchiveBtn.Text = "Faollashtirish";
                        var result = new Modal("Rostdan ham arxivdan chiqarmoqchimisan?").ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            await _businessUnit.ProductService.ActionAsync(selectedId, ActionType.Recover);
                            await Task.Run(() => FillProducts(selected));
                            new Toastr().ShowSuccess("Muvoffaqqiyatli arxivdan chiqarildi");
                        }
                    }
                    else
                    {
                        new Toastr().ShowWarning("Foallashtirish uchun bironta kategoriyani tanlang");
                    }
                }
            }
            catch (Exception ex)
            {
                new Toastr().ShowError("Arxivelashda hatolik yuz berdi");
            }
        }
        else
        {
            if (ProductCategoryComboBox.Text == "Arxivlangan")
            {
                new Toastr().ShowWarning("Faollashtirish uchun kategoriyalardan birini tanlang!");

            }
            else
            {
                new Toastr().ShowWarning("Arxivelash uchun kategoriyalardan birini tanlang!");

            }
        }
    }
    /// <summary>
    /// Arxive buttonni yo'qotish
    /// </summary>
    private void UpdateArchiveButton()
    {
        if (ProductCategoryComboBox.Text == "Arxivlangan")
        {
            ArchiveBtn.Text = "Faollashtirish";
            ArchiveBtn.Visible = true;
        }
        else if (ProductCategoryComboBox.Text == "Aktiv")
        {
            ArchiveBtn.Text = "Arxivlash";
            ArchiveBtn.Visible = true;

        }
        else
        {
            ArchiveBtn.Visible = false;

        }
    }

    /// <summary>
    /// Product categoriya bo'yicha saralash uchun ComboBox qo'yilgan 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void ProductCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        selected = ProductCategoryComboBox.Text switch
        {
            "Aktiv" => State.Active,
            "Arxivlangan" => State.Archive,
            _ => State.All
        };
        await Task.Run(() => FillProducts(selected));
        UpdateArchiveButton();
    }

    private async void search_textbox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (!string.IsNullOrEmpty(search_textbox.Text))
            {
                var filter = await _businessUnit.ProductService
                                .FilterByNameAsync(search_textbox.Text, selected, selectedCategoryId);
    
                var searchResult = filter.Select(i => new {
                                                Id = i.Id,
                                                Kodi = i.Barcode,
                                                Nomi = i.Name,
                                                Miqdori = i.Amount,
                                                OlchovTuri = i.MeasurmentType.ToString(),
                                                Izoh = i.Description,
                                                Kategoriyasi = i.Category.Name,
                                            }).ToList();

                if (searchResult != null && searchResult.Any())
                {
                    table.DataSource = searchResult;
                }
                else
                {
                    table.DataSource = new List<ProductDto>();
                    new Toastr().ShowWarning("Bunday mahsulot mavjud emas");
                }
            }
            else
            {
                await Task.Run(() => FillProducts(selected));
            }
        }
        catch (Exception)
        {
            new Toastr().ShowError("Xatolik yuz berdi");
        }
    }
}

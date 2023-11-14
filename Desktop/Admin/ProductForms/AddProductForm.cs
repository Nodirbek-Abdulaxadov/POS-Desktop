﻿using Desktop.Extended;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Common.DataTransferObjects.ProductDtos;
using POS.Application.Common.Exceptions;
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
    }

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        AddProductDto productDto = new()
        {
            Name = name_textbox.Text,
            Barcode = barcode.Text.Trim()??"000000000000",
            WarningAmount = int.Parse(
                            string.IsNullOrEmpty(warningAmount.Text.Trim())?
                            "0": warningAmount.Text.Trim()),
            CategoryId = _categories.FirstOrDefault(x => x.Name == category.Text).Id,
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

    private async void AddProductForm_Load(object sender, EventArgs e)
    {
        _categories = await _businessUnit.CategoryService
                                         .GetAllAsync();
        category.DataSource = _categories.Select(x => x.Name)
                                         .ToArray();
        mtype.DataSource = Enum.GetValues(typeof(MeasurmentType));
    }
}

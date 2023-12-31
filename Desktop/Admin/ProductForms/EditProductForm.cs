﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.Extended;
using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Common.DataTransferObjects.ProductDtos;
using POS.Application.Common.Exceptions;
using POS.Application.Interfaces;
using POS.Domain.Enums;

namespace Desktop.Admin.ProductForms;
public partial class EditProductForm : Form
{
    private readonly IBusinessUnit _businessUnit;
    private List<CategoryDto> _categories;
    private readonly int _Id;
    public EditProductForm(int Id, IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _Id = Id;
        _businessUnit = businessUnit;
    }

    private void CanselBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private async Task SaveProduct()
    {
        UpdateProductDto productDto = new()
        {
            Id = _Id,
            Name = name_textbox.Text,
            Barcode = barcode.Text.Trim() ?? "000000000000",
            WarningAmount = decimal.Parse(
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
                await _businessUnit.ProductService.UpdateAsync(productDto);
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

    private async void EditProductForm_Load(object sender, EventArgs e)
    {
        try
        {
            _categories = await _businessUnit.CategoryService
                                         .GetAllAsync();
            categoryComboBox.DataSource = _categories.Select(x => x.Name)
                                             .ToArray();
            mtype.DataSource = Enum.GetValues(typeof(MeasurmentType));

            var productDto = await _businessUnit.ProductService.GetByIdAsync(_Id);
            name_textbox.Text = productDto.Name;
            barcode.Text = productDto.Barcode;
            warningAmount.Text = productDto.WarningAmount.ToString();
            description.Text = productDto.Description;

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

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        await SaveProduct();
    }
}

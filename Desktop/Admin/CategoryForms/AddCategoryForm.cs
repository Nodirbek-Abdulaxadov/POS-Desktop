﻿using Desktop.Extended;
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
    }

    /// <summary>
    /// Save button click event - save new category
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
        catch (MarketException ex)
        {
            new Toastr().ShowError(ex.ErrorMessage);
        }
        catch (Exception)
        {
            new Toastr().ShowError();
        }
    }
}

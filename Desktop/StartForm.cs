using Desktop.Auth;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Common.Enums;
using POS.Application.Interfaces;
using POS.Application.Services;
using POS.Domain.Interfaces;

namespace Desktop;

public partial class StartForm : Form
{
    private readonly IBusinessUnit _businessUnit;

    public StartForm(IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _businessUnit = businessUnit;
    }

    /// <summary>
    /// Super Admin login button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button1_Click(object sender, EventArgs e)
    {
        OpenLoginForm(UserRoles.SuperAdmin);
    }

    /// <summary>
    /// Admin login button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button2_Click(object sender, EventArgs e)
    {
        OpenLoginForm(UserRoles.Admin);
    }

    /// <summary>
    /// Seller login button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button3_Click(object sender, EventArgs e)
    {
        OpenLoginForm(UserRoles.Seller);
    }

    private void OpenLoginForm(UserRoles role)
    {
        Login login = new(role, _businessUnit);
        Hide();
        login.ShowDialog();
        Close();
    }
}

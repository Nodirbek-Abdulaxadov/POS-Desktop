using Desktop.Admin;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Common.Enums;
using POS.Application.Interfaces;

namespace Desktop.Auth;
public partial class Login : Form
{
    public UserRoles _role;
    private readonly IBusinessUnit _businessUnit;

    public Login(UserRoles role, IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _role = role;
        _businessUnit = businessUnit;
    }

    /// <summary>
    /// back to start form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button2_Click(object sender, EventArgs e)
    {
        StartForm start = new(_businessUnit);
        this.Hide();
        start.ShowDialog();
        this.Close();
    }

    /// <summary>
    /// login
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        string phone = phoneNumber.Text.Replace("+", "").Replace("-", "").Replace(" ", "");
        var result = await _businessUnit.AuthService.LoginAsync(phone, password.Text, _role);
        if (result.IsSuccess)
        {
            switch (_role)
            {
                case UserRoles.Admin:
                    {
                        AdminForm admin = new(_businessUnit);
                        Hide();
                        admin.ShowDialog();
                        Close();
                    }
                    break;
                case UserRoles.SuperAdmin:
                    {
                        AdminForm admin = new(_businessUnit);
                        Hide();
                        admin.ShowDialog();
                        Close();
                    }
                    break;
                case UserRoles.Seller:
                    {
                        AdminForm admin = new(_businessUnit);
                        Hide();
                        admin.ShowDialog();
                        Close();
                    }
                    break;
            }
        }
        else
        {
            MessageBox.Show(result.ErrorMessage);
        }
    }

    private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (checkbox.Checked)
        {
            password.UseSystemPasswordChar = false;
            password.PasswordChar = '\0';
        }
        else
        {
            password.UseSystemPasswordChar = true;
            password.PasswordChar = '\u25CF';
        }
    }
}

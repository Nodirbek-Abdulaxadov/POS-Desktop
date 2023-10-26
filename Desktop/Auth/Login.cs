using Microsoft.Extensions.DependencyInjection;
using POS.Application.Common.Enums;
using POS.Application.Interfaces;

namespace Desktop.Auth;
public partial class Login : Form
{
    public UserRoles _role;
    public IAuthInterface _authInterface;

    public Login(UserRoles role)
    {
        InitializeComponent();
        _role = role;
        _authInterface = Configuration.GetServiceProvider()
                                      .GetRequiredService<IAuthInterface>();
    }

    /// <summary>
    /// back to start form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button2_Click(object sender, EventArgs e)
    {
        StartForm start = new();
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
        var result = await _authInterface.LoginAsync(phone, password.Text, _role);
        if (result.IsSuccess)
        {
            MessageBox.Show("");
        }
        else
        {
            MessageBox.Show(result.ErrorMessage);
        }
    }
}

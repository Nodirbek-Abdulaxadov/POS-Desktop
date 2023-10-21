using Desktop.Auth;

namespace Desktop;

public partial class StartForm : Form
{
    public StartForm()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Super Admin login button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button1_Click(object sender, EventArgs e)
    {
        Login login = new();
        Hide();
        login.ShowDialog();
        Close();
    }

    /// <summary>
    /// Admin login button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button2_Click(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Seller login button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button3_Click(object sender, EventArgs e)
    {

    }
}

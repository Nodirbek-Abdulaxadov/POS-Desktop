namespace Desktop.Extended;
public partial class Toastr : Form
{
    public Toastr()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.Manual;
        foreach (var scrn in Screen.AllScreens)
        {
            if (scrn.Bounds.Contains(Location))
            {
                Location = new Point((scrn.Bounds.Right - Width )/2, scrn.Bounds.Top + 20);
                return;
            }
        }
    }

    /// <summary>
    /// close toastr
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void close_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    /// Show success
    /// </summary>
    public void ShowSuccess()
    {
        icon.Image = Properties.Resources.success_icon;
        message.Text = "Muvoffaqqiyatli saqlandi!";
        BackColor = Color.FromArgb(113, 179, 113);
        Show();
    }

    /// <summary>
    /// Show success with custom message
    /// </summary>
    /// <param name="msg"></param>
    public void ShowSuccess(string msg)
    {
        icon.Image = Properties.Resources.success_icon;
        message.Text = msg;
        BackColor = Color.FromArgb(113, 179, 113);
        Show();
    }

    /// <summary>
    /// Show error
    /// </summary>
    public void ShowError()
    {
        icon.Image = Properties.Resources.error_icon;
        message.Text = "Xatolik yuz berdi!";
        BackColor = Color.FromArgb(202, 94, 88);
        Show();
    }

    /// <summary>
    /// Show error with custom message
    /// </summary>
    public void ShowError(string msg)
    {
        icon.Image = Properties.Resources.error_icon;
        message.Text = msg;
        BackColor = Color.FromArgb(202, 94, 88);
        Show();
    }

    /// <summary>
    /// Show warning with custom message
    /// </summary>
    /// <param name="msg"></param>
    public void ShowWarning(string msg)
    {
        icon.Image = Properties.Resources.warning_icon;
        message.Text = msg;
        BackColor = Color.FromArgb(247, 167, 53);
        Show();
    }

    /// <summary>
    /// load event - close after 3 seconds
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void Toastr_Load(object sender, EventArgs e)
    {
        await Task.Delay(3000);
        Close();
    }
}

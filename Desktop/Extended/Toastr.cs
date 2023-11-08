namespace Desktop.Extended;
public partial class Toastr : Form
{
    public Toastr()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.Manual;
        foreach (var scrn in Screen.AllScreens)
        {
            if (scrn.Bounds.Contains(this.Location))
            {
                this.Location = new Point(scrn.Bounds.Right - this.Width - 20, scrn.Bounds.Top + 20);
                return;
            }
        }
    }

    private void close_Click(object sender, EventArgs e)
    {
        Close();
    }

    public void ShowSuccess()
    {
        icon.Image = Properties.Resources.success_icon;
        message.Text = "Muvoffaqqiyatli saqlandi!";
        BackColor = Color.FromArgb(113, 179, 113);
        Show();
    }

    public void ShowError()
    {
        icon.Image = Properties.Resources.error_icon;
        message.Text = "Xatolik yuz berdi!";
        BackColor = Color.FromArgb(202, 94, 88);
        Show();
    }

    private async void Toastr_Load(object sender, EventArgs e)
    {
        await Task.Delay(3000);
        Close();
    }
}

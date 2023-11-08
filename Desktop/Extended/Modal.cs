namespace Desktop.Extended;
public partial class Modal : Form
{
    public Modal()
    {
        InitializeComponent();
    }

    /// <summary>
    /// returns DialogResult.No
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button1_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.No;
        Close();
    }

    /// <summary>
    /// return DialogResult.OK
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button2_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }

    /// <summary>
    /// Close dialog
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button3_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}

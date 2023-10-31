namespace Desktop.Extended;
public partial class Toastr : Form
{
    public Toastr()
    {
        Screen primaryScreen = Screen.PrimaryScreen;

        // Calculate the top-right location
        int topRightX = primaryScreen.Bounds.Right;
        int topRightY = primaryScreen.Bounds.Top;
        Point topRightLocation = new Point(800, 800);
        this.Location = topRightLocation;
        InitializeComponent();
    }

    bool opened = false;

    private void Toastr_Load(object sender, EventArgs e)
    {
        toastTimer.Start();
    }

    private void toastTimer_Tick(object sender, EventArgs e)
    {
        if (opened)
        {
            Hide();
        }
        else
        {
            opened = true;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Hide();
    }
}

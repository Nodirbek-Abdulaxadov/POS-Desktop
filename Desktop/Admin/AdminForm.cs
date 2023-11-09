using Desktop.Admin.CategoryForms;
using Desktop.Admin.ProductForms;
using Desktop.Properties;
using Guna.UI2.WinForms;
using POS.Application.Interfaces;
using Timer = System.Windows.Forms.Timer;

namespace Desktop.Admin;
public partial class AdminForm : Form
{
    private readonly IBusinessUnit _businessUnit;

    public AdminForm(IBusinessUnit businessUnit)
    {
        InitializeComponent();
        _businessUnit = businessUnit;
    }

    #region Sidebar
    private bool _sidebarCollapsed = false;
    private readonly int targetCollapsedSidebarWidth = 90;
    private readonly int targetCollapsedButtonWidth = 50;
    private readonly int targetExpandedSidebarWidth = 270;
    private readonly int targetExpandedButtonWidth = 230;
    private Timer? collapseAnimationTimer;
    private Timer? expandAnimationTimer;
    private readonly int sidebarIncrement = 10;
    private readonly int buttonIncrement = 10;
    private readonly Color dark = Color.FromArgb(176, 203, 224);
    private readonly Color blue = Color.FromArgb(75, 73, 172);

    /// <summary>
    /// sidebar toggle button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void guna2Button2_Click(object sender, EventArgs e)
    {
        if (_sidebarCollapsed)
        {
            StartExpandAnimation();
        }
        else
        {
            StartCollapseAnimation();
        }
    }
    private void StartCollapseAnimation()
    {
        if (collapseAnimationTimer != null && collapseAnimationTimer.Enabled)
        {
            // If there's an ongoing collapse animation, stop it.
            collapseAnimationTimer.Stop();
            collapseAnimationTimer.Dispose();
        }

        collapseAnimationTimer = new Timer();
        collapseAnimationTimer.Interval = 5; // Adjust this interval as needed for smoother animation.
        collapseAnimationTimer.Tick += (sender, e) =>
        {
            if (sidebar.Width > targetCollapsedSidebarWidth && sidebar.Width > 0)
            {
                sidebar.Width -= sidebarIncrement;
                reportBtn.Width -= buttonIncrement;
                categoryBtn.Width -= buttonIncrement;
                productBtn.Width -= buttonIncrement;
                itemsBtn.Width -= buttonIncrement;
            }
            else
            {
                _sidebarCollapsed = true;
                collapseAnimationTimer.Stop();
                collapseAnimationTimer.Dispose();
            }
        };

        collapseAnimationTimer.Start();
    }
    private void StartExpandAnimation()
    {
        if (expandAnimationTimer != null && expandAnimationTimer.Enabled)
        {
            // If there's an ongoing expand animation, stop it.
            expandAnimationTimer.Stop();
            expandAnimationTimer.Dispose();
        }

        expandAnimationTimer = new Timer();
        expandAnimationTimer.Interval = 5; // Adjust this interval as needed for smoother animation.
        expandAnimationTimer.Tick += (sender, e) =>
        {
            if (sidebar.Width < targetExpandedSidebarWidth)
            {
                sidebar.Width += sidebarIncrement;
                reportBtn.Width += buttonIncrement;
                categoryBtn.Width += buttonIncrement;
                productBtn.Width += buttonIncrement;
                itemsBtn.Width += buttonIncrement;
            }
            else
            {
                _sidebarCollapsed = false;
                expandAnimationTimer.Stop();
                expandAnimationTimer.Dispose();
            }
        };

        expandAnimationTimer.Start();
    }

    private void reportBtn_Click(object sender, EventArgs e)
    {
        EnableButton((Guna2Button)sender);
        OpenCategoriesTable();
    }

    private void productBtn_Click(object sender, EventArgs e)
    {
        EnableButton((Guna2Button)sender);
        OpenProductsTable();
    }

    private void productItemBtn_Click(object sender, EventArgs e)
    {
        EnableButton((Guna2Button)sender);
        OpenCategoriesTable();
    }

    private void DisableAll()
    {
        reportBtn.FillColor = Color.White;
        reportBtn.ForeColor = dark;
        reportBtn.Image = Resources.home_dark;

        categoryBtn.FillColor = Color.White;
        categoryBtn.ForeColor = dark;
        categoryBtn.Image = Resources.category_dark;

        productBtn.FillColor = Color.White;
        productBtn.ForeColor = dark;
        productBtn.Image = Resources.cart_dark;

        itemsBtn.FillColor = Color.White;
        itemsBtn.ForeColor = dark;
        itemsBtn.Image = Resources.item_dark;
    }

    private void EnableButton(Guna2Button button)
    {
        DisableAll();
        switch (button.Text)
        {
            case "Hisobotlar":
                {
                    reportBtn.FillColor = blue;
                    reportBtn.ForeColor = Color.White;
                    reportBtn.Image = Resources.home_light;
                }
                break;
            case "Kategoriyalar":
                {
                    categoryBtn.FillColor = blue;
                    categoryBtn.ForeColor = Color.White;
                    categoryBtn.Image = Resources.category_ligth;
                }
                break;
            case "Mahsulotlar":
                {
                    productBtn.FillColor = blue;
                    productBtn.ForeColor = Color.White;
                    productBtn.Image = Resources.cart_light;
                }
                break;
            case "Kirimlar":
                {
                    itemsBtn.FillColor = blue;
                    itemsBtn.ForeColor = Color.White;
                    itemsBtn.Image = Resources.item_light;
                }
                break;
        }
    }
    #endregion

    #region Top panel
    private Point mouseOffset;
    private bool isMouseDown = false;
    private void guna2Button1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Maximized)
        {
            WindowState = FormWindowState.Normal;
        }
        else
        {
            WindowState = FormWindowState.Maximized;
        }
    }

    private void guna2Button4_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void guna2ShadowPanel1_MouseDown(object sender, MouseEventArgs e)
    {
        if (WindowState == FormWindowState.Maximized)
        {
            WindowState = FormWindowState.Normal;
        }

        if (e.Button == MouseButtons.Left)
        {
            isMouseDown = true;
            mouseOffset = new Point(-e.X, -e.Y);
        }
    }

    private void guna2ShadowPanel1_MouseMove(object sender, MouseEventArgs e)
    {

        if (isMouseDown)
        {
            Point mousePos = Control.MousePosition;
            mousePos.Offset(mouseOffset.X, mouseOffset.Y);
            Location = mousePos;
        }
    }

    private void guna2ShadowPanel1_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isMouseDown = false;
        }
    }
    #endregion

    private void AdminForm_Load(object sender, EventArgs e)
    {

    }

    private void OpenCategoriesTable()
    {
        CategoryTable table = new(_businessUnit);
        table.Dock = DockStyle.Fill;
        main.Controls.Clear();
        main.Controls.Add(table);
    }

    private void OpenProductsTable()
    {
        ProductTable table = new(_businessUnit);
        table.Dock = DockStyle.Fill;
        main.Controls.Clear();
        main.Controls.Add(table);
    }
}

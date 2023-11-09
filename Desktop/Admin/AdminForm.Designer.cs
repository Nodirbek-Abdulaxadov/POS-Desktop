namespace Desktop.Admin;

partial class AdminForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        reportBtn = new Guna.UI2.WinForms.Guna2Button();
        pictureBox1 = new PictureBox();
        label1 = new Label();
        guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
        panel1 = new Panel();
        guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        sidebar = new Guna.UI2.WinForms.Guna2ShadowPanel();
        itemsBtn = new Guna.UI2.WinForms.Guna2Button();
        productBtn = new Guna.UI2.WinForms.Guna2Button();
        categoryBtn = new Guna.UI2.WinForms.Guna2Button();
        guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
        main = new Panel();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        guna2ShadowPanel1.SuspendLayout();
        panel1.SuspendLayout();
        sidebar.SuspendLayout();
        SuspendLayout();
        // 
        // reportBtn
        // 
        reportBtn.BorderRadius = 8;
        reportBtn.Cursor = Cursors.Hand;
        reportBtn.CustomizableEdges = customizableEdges1;
        reportBtn.DisabledState.BorderColor = Color.DarkGray;
        reportBtn.DisabledState.CustomBorderColor = Color.DarkGray;
        reportBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        reportBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        reportBtn.FillColor = Color.FromArgb(75, 73, 172);
        reportBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        reportBtn.ForeColor = Color.White;
        reportBtn.Image = Properties.Resources.home_light;
        reportBtn.ImageAlign = HorizontalAlignment.Left;
        reportBtn.ImageSize = new Size(25, 25);
        reportBtn.Location = new Point(20, 21);
        reportBtn.Name = "reportBtn";
        reportBtn.Padding = new Padding(10, 0, 0, 0);
        reportBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
        reportBtn.Size = new Size(228, 50);
        reportBtn.TabIndex = 6;
        reportBtn.Text = "Hisobotlar";
        reportBtn.TextAlign = HorizontalAlignment.Left;
        reportBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
        reportBtn.Click += reportBtn_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(12, 11);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(73, 54);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        pictureBox1.MouseDown += guna2ShadowPanel1_MouseDown;
        pictureBox1.MouseMove += guna2ShadowPanel1_MouseMove;
        pictureBox1.MouseUp += guna2ShadowPanel1_MouseUp;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(85, 18);
        label1.Name = "label1";
        label1.Size = new Size(182, 37);
        label1.TabIndex = 2;
        label1.Text = "Point Of Sale";
        label1.MouseDown += guna2ShadowPanel1_MouseDown;
        label1.MouseMove += guna2ShadowPanel1_MouseMove;
        label1.MouseUp += guna2ShadowPanel1_MouseUp;
        // 
        // guna2ShadowPanel1
        // 
        guna2ShadowPanel1.BackColor = Color.Transparent;
        guna2ShadowPanel1.Controls.Add(panel1);
        guna2ShadowPanel1.Controls.Add(guna2Button2);
        guna2ShadowPanel1.Controls.Add(pictureBox1);
        guna2ShadowPanel1.Controls.Add(label1);
        guna2ShadowPanel1.Dock = DockStyle.Top;
        guna2ShadowPanel1.FillColor = Color.White;
        guna2ShadowPanel1.Location = new Point(0, 0);
        guna2ShadowPanel1.Name = "guna2ShadowPanel1";
        guna2ShadowPanel1.ShadowColor = Color.Black;
        guna2ShadowPanel1.ShadowShift = 3;
        guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
        guna2ShadowPanel1.Size = new Size(1000, 84);
        guna2ShadowPanel1.TabIndex = 3;
        guna2ShadowPanel1.DoubleClick += guna2Button3_Click;
        guna2ShadowPanel1.MouseDown += guna2ShadowPanel1_MouseDown;
        guna2ShadowPanel1.MouseMove += guna2ShadowPanel1_MouseMove;
        guna2ShadowPanel1.MouseUp += guna2ShadowPanel1_MouseUp;
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        panel1.Controls.Add(guna2Button4);
        panel1.Controls.Add(guna2Button3);
        panel1.Controls.Add(guna2Button1);
        panel1.Location = new Point(849, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(150, 25);
        panel1.TabIndex = 5;
        // 
        // guna2Button4
        // 
        guna2Button4.Cursor = Cursors.Hand;
        guna2Button4.CustomizableEdges = customizableEdges3;
        guna2Button4.DisabledState.BorderColor = Color.DarkGray;
        guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button4.FillColor = Color.Transparent;
        guna2Button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button4.ForeColor = Color.White;
        guna2Button4.Image = (Image)resources.GetObject("guna2Button4.Image");
        guna2Button4.Location = new Point(1, 0);
        guna2Button4.Name = "guna2Button4";
        guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges4;
        guna2Button4.Size = new Size(50, 25);
        guna2Button4.TabIndex = 6;
        guna2Button4.Click += guna2Button4_Click;
        // 
        // guna2Button3
        // 
        guna2Button3.Cursor = Cursors.Hand;
        guna2Button3.CustomizableEdges = customizableEdges5;
        guna2Button3.DisabledState.BorderColor = Color.DarkGray;
        guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button3.FillColor = Color.Transparent;
        guna2Button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button3.ForeColor = Color.White;
        guna2Button3.Image = (Image)resources.GetObject("guna2Button3.Image");
        guna2Button3.Location = new Point(50, 0);
        guna2Button3.Name = "guna2Button3";
        guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges6;
        guna2Button3.Size = new Size(50, 25);
        guna2Button3.TabIndex = 5;
        guna2Button3.Click += guna2Button3_Click;
        // 
        // guna2Button1
        // 
        guna2Button1.Cursor = Cursors.Hand;
        guna2Button1.CustomizableEdges = customizableEdges7;
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.Red;
        guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Location = new Point(100, 0);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
        guna2Button1.Size = new Size(50, 25);
        guna2Button1.TabIndex = 4;
        guna2Button1.Text = "X";
        guna2Button1.Click += guna2Button1_Click;
        // 
        // guna2Button2
        // 
        guna2Button2.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button2.BorderRadius = 8;
        guna2Button2.Cursor = Cursors.Hand;
        guna2Button2.CustomizableEdges = customizableEdges9;
        guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button2.FillColor = Color.Transparent;
        guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        guna2Button2.ForeColor = Color.White;
        guna2Button2.Image = (Image)resources.GetObject("guna2Button2.Image");
        guna2Button2.ImageSize = new Size(30, 30);
        guna2Button2.Location = new Point(282, 17);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges10;
        guna2Button2.Size = new Size(48, 46);
        guna2Button2.TabIndex = 3;
        guna2Button2.Click += guna2Button2_Click;
        // 
        // sidebar
        // 
        sidebar.BackColor = Color.Transparent;
        sidebar.Controls.Add(itemsBtn);
        sidebar.Controls.Add(productBtn);
        sidebar.Controls.Add(categoryBtn);
        sidebar.Controls.Add(reportBtn);
        sidebar.Dock = DockStyle.Left;
        sidebar.FillColor = Color.White;
        sidebar.Location = new Point(0, 84);
        sidebar.Name = "sidebar";
        sidebar.ShadowColor = Color.Black;
        sidebar.ShadowShift = 1;
        sidebar.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
        sidebar.Size = new Size(267, 466);
        sidebar.TabIndex = 7;
        // 
        // itemsBtn
        // 
        itemsBtn.BorderRadius = 8;
        itemsBtn.Cursor = Cursors.Hand;
        itemsBtn.CustomizableEdges = customizableEdges11;
        itemsBtn.DisabledState.BorderColor = Color.DarkGray;
        itemsBtn.DisabledState.CustomBorderColor = Color.DarkGray;
        itemsBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        itemsBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        itemsBtn.FillColor = Color.White;
        itemsBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        itemsBtn.ForeColor = Color.FromArgb(176, 203, 224);
        itemsBtn.Image = Properties.Resources.item_dark;
        itemsBtn.ImageAlign = HorizontalAlignment.Left;
        itemsBtn.ImageSize = new Size(25, 25);
        itemsBtn.Location = new Point(20, 225);
        itemsBtn.Name = "itemsBtn";
        itemsBtn.Padding = new Padding(10, 0, 0, 0);
        itemsBtn.ShadowDecoration.CustomizableEdges = customizableEdges12;
        itemsBtn.Size = new Size(228, 50);
        itemsBtn.TabIndex = 9;
        itemsBtn.Text = "Kirimlar";
        itemsBtn.TextAlign = HorizontalAlignment.Left;
        itemsBtn.Click += productItemBtn_Click;
        // 
        // productBtn
        // 
        productBtn.BorderRadius = 8;
        productBtn.Cursor = Cursors.Hand;
        productBtn.CustomizableEdges = customizableEdges13;
        productBtn.DisabledState.BorderColor = Color.DarkGray;
        productBtn.DisabledState.CustomBorderColor = Color.DarkGray;
        productBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        productBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        productBtn.FillColor = Color.White;
        productBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        productBtn.ForeColor = Color.FromArgb(176, 203, 224);
        productBtn.Image = Properties.Resources.cart_dark;
        productBtn.ImageAlign = HorizontalAlignment.Left;
        productBtn.ImageSize = new Size(25, 25);
        productBtn.Location = new Point(20, 157);
        productBtn.Name = "productBtn";
        productBtn.Padding = new Padding(10, 0, 0, 0);
        productBtn.ShadowDecoration.CustomizableEdges = customizableEdges14;
        productBtn.Size = new Size(228, 50);
        productBtn.TabIndex = 8;
        productBtn.Text = "Mahsulotlar";
        productBtn.TextAlign = HorizontalAlignment.Left;
        productBtn.Click += productBtn_Click;
        // 
        // categoryBtn
        // 
        categoryBtn.BorderRadius = 8;
        categoryBtn.Cursor = Cursors.Hand;
        categoryBtn.CustomizableEdges = customizableEdges15;
        categoryBtn.DisabledState.BorderColor = Color.DarkGray;
        categoryBtn.DisabledState.CustomBorderColor = Color.DarkGray;
        categoryBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        categoryBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        categoryBtn.FillColor = Color.White;
        categoryBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        categoryBtn.ForeColor = Color.FromArgb(176, 203, 224);
        categoryBtn.Image = Properties.Resources.category_dark;
        categoryBtn.ImageAlign = HorizontalAlignment.Left;
        categoryBtn.ImageSize = new Size(25, 25);
        categoryBtn.Location = new Point(20, 89);
        categoryBtn.Name = "categoryBtn";
        categoryBtn.Padding = new Padding(10, 0, 0, 0);
        categoryBtn.ShadowDecoration.CustomizableEdges = customizableEdges16;
        categoryBtn.Size = new Size(228, 50);
        categoryBtn.TabIndex = 7;
        categoryBtn.Text = "Kategoriyalar";
        categoryBtn.TextAlign = HorizontalAlignment.Left;
        categoryBtn.Click += reportBtn_Click;
        // 
        // guna2ShadowForm1
        // 
        guna2ShadowForm1.TargetForm = this;
        // 
        // main
        // 
        main.BackColor = Color.FromArgb(220, 229, 253);
        main.Dock = DockStyle.Fill;
        main.Location = new Point(267, 84);
        main.Name = "main";
        main.Padding = new Padding(30, 5, 30, 15);
        main.Size = new Size(733, 466);
        main.TabIndex = 8;
        // 
        // AdminForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(220, 229, 253);
        ClientSize = new Size(1000, 550);
        Controls.Add(main);
        Controls.Add(sidebar);
        Controls.Add(guna2ShadowPanel1);
        FormBorderStyle = FormBorderStyle.None;
        MinimumSize = new Size(1000, 550);
        Name = "AdminForm";
        StartPosition = FormStartPosition.WindowsDefaultBounds;
        Text = "AdminForm";
        WindowState = FormWindowState.Maximized;
        Load += AdminForm_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        guna2ShadowPanel1.ResumeLayout(false);
        guna2ShadowPanel1.PerformLayout();
        panel1.ResumeLayout(false);
        sidebar.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private PictureBox pictureBox1;
    private Guna.UI2.WinForms.Guna2Button reportBtn;
    private Label label1;
    private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    private Guna.UI2.WinForms.Guna2ShadowPanel sidebar;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
    private Guna.UI2.WinForms.Guna2Button itemsBtn;
    private Guna.UI2.WinForms.Guna2Button productBtn;
    private Guna.UI2.WinForms.Guna2Button categoryBtn;
    private Panel panel1;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2Button guna2Button4;
    private Guna.UI2.WinForms.Guna2Button guna2Button3;
    private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    private Panel main;
}
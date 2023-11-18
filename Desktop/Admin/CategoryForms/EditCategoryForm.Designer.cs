namespace Desktop.Admin.CategoryForms;

partial class EditCategoryForm
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
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
        label1 = new Label();
        label2 = new Label();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        CanselBtn = new Guna.UI2.WinForms.Guna2Button();
        SuspendLayout();
        // 
        // name_textbox
        // 
        name_textbox.CustomizableEdges = customizableEdges1;
        name_textbox.DefaultText = "";
        name_textbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        name_textbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        name_textbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        name_textbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        name_textbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        name_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        name_textbox.ForeColor = Color.Black;
        name_textbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        name_textbox.Location = new Point(32, 109);
        name_textbox.Margin = new Padding(4);
        name_textbox.Name = "name_textbox";
        name_textbox.PasswordChar = '\0';
        name_textbox.PlaceholderText = "Kategoriya nomini kiriting";
        name_textbox.SelectedText = "";
        name_textbox.ShadowDecoration.CustomizableEdges = customizableEdges2;
        name_textbox.Size = new Size(314, 49);
        name_textbox.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(32, 80);
        label1.Name = "label1";
        label1.Size = new Size(58, 25);
        label1.TabIndex = 1;
        label1.Text = "Nomi";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(12, 12);
        label2.Name = "label2";
        label2.Size = new Size(229, 30);
        label2.TabIndex = 2;
        label2.Text = "Kategoriyani tahrirlash";
        // 
        // guna2Button1
        // 
        guna2Button1.BorderRadius = 7;
        guna2Button1.Cursor = Cursors.Hand;
        guna2Button1.CustomizableEdges = customizableEdges3;
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.FromArgb(75, 73, 172);
        guna2Button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Location = new Point(213, 202);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
        guna2Button1.Size = new Size(133, 36);
        guna2Button1.TabIndex = 3;
        guna2Button1.Text = "Saqlash";
        guna2Button1.Click += guna2Button1_Click;
        guna2Button1.KeyDown += guna2Button1_KeyDown;
        // 
        // guna2Button2
        // 
        guna2Button2.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button2.BorderColor = Color.LightGray;
        guna2Button2.BorderRadius = 5;
        guna2Button2.BorderThickness = 1;
        guna2Button2.Cursor = Cursors.Hand;
        guna2Button2.CustomizableEdges = customizableEdges5;
        guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button2.FillColor = Color.Transparent;
        guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        guna2Button2.ForeColor = Color.White;
        guna2Button2.Image = Properties.Resources.x;
        guna2Button2.Location = new Point(335, 9);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
        guna2Button2.Size = new Size(40, 40);
        guna2Button2.TabIndex = 4;
        guna2Button2.Click += guna2Button2_Click;
        // 
        // CanselBtn
        // 
        CanselBtn.Anchor = AnchorStyles.None;
        CanselBtn.BorderRadius = 7;
        CanselBtn.Cursor = Cursors.Hand;
        CanselBtn.CustomizableEdges = customizableEdges7;
        CanselBtn.DisabledState.BorderColor = Color.DarkGray;
        CanselBtn.DisabledState.CustomBorderColor = Color.DarkGray;
        CanselBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        CanselBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        CanselBtn.FillColor = Color.FromArgb(192, 0, 0);
        CanselBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        CanselBtn.ForeColor = Color.White;
        CanselBtn.Location = new Point(32, 202);
        CanselBtn.Name = "CanselBtn";
        CanselBtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
        CanselBtn.Size = new Size(133, 36);
        CanselBtn.TabIndex = 6;
        CanselBtn.Text = "Bekor qilish";
        CanselBtn.Click += CanselBtn_Click;
        // 
        // EditCategoryForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(220, 229, 253);
        ClientSize = new Size(384, 275);
        Controls.Add(CanselBtn);
        Controls.Add(guna2Button2);
        Controls.Add(guna2Button1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(name_textbox);
        FormBorderStyle = FormBorderStyle.None;
        Name = "EditCategoryForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "AddCategoryForm";
        Load += EditCategoryForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Guna.UI2.WinForms.Guna2TextBox name_textbox;
    private Label label1;
    private Label label2;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
    private Guna.UI2.WinForms.Guna2Button CanselBtn;
}
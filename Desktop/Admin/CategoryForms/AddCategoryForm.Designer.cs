namespace Desktop.Admin.CategoryForms;

partial class AddCategoryForm
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
        name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
        label1 = new Label();
        label2 = new Label();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        SuspendLayout();
        // 
        // name_textbox
        // 
        name_textbox.Anchor = AnchorStyles.None;
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
        name_textbox.Location = new Point(32, 153);
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
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(32, 124);
        label1.Name = "label1";
        label1.Size = new Size(58, 25);
        label1.TabIndex = 1;
        label1.Text = "Nomi";
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.None;
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(12, 12);
        label2.Name = "label2";
        label2.Size = new Size(253, 30);
        label2.TabIndex = 2;
        label2.Text = "Yangi kategoriya qo'shish";
        // 
        // guna2Button1
        // 
        guna2Button1.Anchor = AnchorStyles.None;
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
        guna2Button1.Location = new Point(98, 233);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
        guna2Button1.Size = new Size(179, 50);
        guna2Button1.TabIndex = 3;
        guna2Button1.Text = "Saqlash";
        guna2Button1.Click += guna2Button1_Click;
        // 
        // AddCategoryForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(220, 229, 253);
        ClientSize = new Size(384, 315);
        Controls.Add(guna2Button1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(name_textbox);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "AddCategoryForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "AddCategoryForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Guna.UI2.WinForms.Guna2TextBox name_textbox;
    private Label label1;
    private Label label2;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
}
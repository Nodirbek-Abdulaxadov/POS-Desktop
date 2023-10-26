namespace Desktop.Auth;

partial class Login
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        pictureBox1 = new PictureBox();
        label1 = new Label();
        phoneNumber = new MaskedTextBox();
        password = new Guna.UI2.WinForms.Guna2TextBox();
        label2 = new Label();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
        linkLabel1 = new LinkLabel();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = AnchorStyles.None;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(103, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(207, 194);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = SystemColors.ControlDark;
        label1.Location = new Point(51, 250);
        label1.Name = "label1";
        label1.Size = new Size(180, 25);
        label1.TabIndex = 1;
        label1.Text = "Telefon raqamingiz:";
        // 
        // phoneNumber
        // 
        phoneNumber.Anchor = AnchorStyles.None;
        phoneNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        phoneNumber.Location = new Point(57, 280);
        phoneNumber.Mask = "+000 00 000 0000";
        phoneNumber.Name = "phoneNumber";
        phoneNumber.Size = new Size(300, 33);
        phoneNumber.TabIndex = 2;
        phoneNumber.Text = "998";
        // 
        // password
        // 
        password.Anchor = AnchorStyles.None;
        password.CustomizableEdges = customizableEdges7;
        password.DefaultText = "";
        password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        password.Location = new Point(57, 373);
        password.Margin = new Padding(5);
        password.Name = "password";
        password.PasswordChar = '\0';
        password.PlaceholderText = "";
        password.SelectedText = "";
        password.ShadowDecoration.CustomizableEdges = customizableEdges8;
        password.Size = new Size(300, 33);
        password.TabIndex = 3;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.None;
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = SystemColors.ControlDark;
        label2.Location = new Point(51, 343);
        label2.Name = "label2";
        label2.Size = new Size(101, 25);
        label2.TabIndex = 4;
        label2.Text = "Parolingiz:";
        // 
        // guna2Button1
        // 
        guna2Button1.Anchor = AnchorStyles.None;
        guna2Button1.BorderRadius = 23;
        guna2Button1.Cursor = Cursors.Hand;
        guna2Button1.CustomizableEdges = customizableEdges9;
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.FromArgb(71, 202, 193);
        guna2Button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Location = new Point(221, 473);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges10;
        guna2Button1.Size = new Size(136, 47);
        guna2Button1.TabIndex = 5;
        guna2Button1.Text = "Kirish";
        guna2Button1.Click += guna2Button1_Click;
        // 
        // guna2CheckBox1
        // 
        guna2CheckBox1.Anchor = AnchorStyles.None;
        guna2CheckBox1.AutoSize = true;
        guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
        guna2CheckBox1.CheckedState.BorderRadius = 0;
        guna2CheckBox1.CheckedState.BorderThickness = 0;
        guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
        guna2CheckBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        guna2CheckBox1.Location = new Point(57, 420);
        guna2CheckBox1.Name = "guna2CheckBox1";
        guna2CheckBox1.Size = new Size(111, 25);
        guna2CheckBox1.TabIndex = 6;
        guna2CheckBox1.Text = "Eslab qolish";
        guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
        guna2CheckBox1.UncheckedState.BorderRadius = 0;
        guna2CheckBox1.UncheckedState.BorderThickness = 0;
        guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
        // 
        // linkLabel1
        // 
        linkLabel1.Anchor = AnchorStyles.None;
        linkLabel1.AutoSize = true;
        linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        linkLabel1.LinkColor = Color.FromArgb(0, 0, 192);
        linkLabel1.Location = new Point(236, 424);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(121, 21);
        linkLabel1.TabIndex = 8;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Parolni unutdim";
        // 
        // guna2Button2
        // 
        guna2Button2.Anchor = AnchorStyles.None;
        guna2Button2.BorderRadius = 23;
        guna2Button2.Cursor = Cursors.Hand;
        guna2Button2.CustomizableEdges = customizableEdges11;
        guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button2.FillColor = Color.Gray;
        guna2Button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        guna2Button2.ForeColor = Color.White;
        guna2Button2.Location = new Point(53, 473);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges12;
        guna2Button2.Size = new Size(136, 47);
        guna2Button2.TabIndex = 9;
        guna2Button2.Text = "Orqaga";
        guna2Button2.Click += guna2Button2_Click;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(419, 548);
        Controls.Add(guna2Button2);
        Controls.Add(linkLabel1);
        Controls.Add(guna2CheckBox1);
        Controls.Add(guna2Button1);
        Controls.Add(label2);
        Controls.Add(password);
        Controls.Add(phoneNumber);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        Name = "Login";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label label1;
    private MaskedTextBox phoneNumber;
    private Guna.UI2.WinForms.Guna2TextBox password;
    private Label label2;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
    private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    private LinkLabel linkLabel1;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
}
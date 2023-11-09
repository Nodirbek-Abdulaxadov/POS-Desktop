namespace Desktop.Admin.ProductForms;

partial class ProductTable
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        table = new Guna.UI2.WinForms.Guna2DataGridView();
        panel1 = new Panel();
        deletebtn = new Guna.UI2.WinForms.Guna2Button();
        editbtn = new Guna.UI2.WinForms.Guna2Button();
        addbtn = new Guna.UI2.WinForms.Guna2Button();
        panel2 = new Panel();
        label1 = new Label();
        panel3 = new Panel();
        ((System.ComponentModel.ISupportInitialize)table).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // table
        // 
        table.AllowUserToAddRows = false;
        table.AllowUserToDeleteRows = false;
        table.AllowUserToResizeRows = false;
        dataGridViewCellStyle5.BackColor = Color.White;
        dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(71, 69, 94);
        table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
        table.BorderStyle = BorderStyle.Fixed3D;
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = Color.FromArgb(75, 73, 172);
        dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        dataGridViewCellStyle6.ForeColor = Color.White;
        dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(75, 73, 172);
        dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
        table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
        table.ColumnHeadersHeight = 28;
        table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle7.BackColor = Color.White;
        dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
        table.DefaultCellStyle = dataGridViewCellStyle7;
        table.Dock = DockStyle.Fill;
        table.GridColor = Color.FromArgb(231, 229, 255);
        table.Location = new Point(0, 50);
        table.Margin = new Padding(30);
        table.Name = "table";
        table.ReadOnly = true;
        table.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle8.BackColor = Color.White;
        dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle8.SelectionBackColor = Color.White;
        dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
        table.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
        table.RowHeadersVisible = false;
        table.RowTemplate.Height = 25;
        table.Size = new Size(750, 295);
        table.TabIndex = 0;
        table.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        table.ThemeStyle.AlternatingRowsStyle.Font = null;
        table.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        table.ThemeStyle.BackColor = Color.White;
        table.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        table.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        table.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
        table.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        table.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        table.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        table.ThemeStyle.HeaderStyle.Height = 28;
        table.ThemeStyle.ReadOnly = true;
        table.ThemeStyle.RowsStyle.BackColor = Color.White;
        table.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        table.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        table.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        table.ThemeStyle.RowsStyle.Height = 25;
        table.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        table.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        table.CellClick += table_CellClick;
        // 
        // panel1
        // 
        panel1.Controls.Add(deletebtn);
        panel1.Controls.Add(editbtn);
        panel1.Controls.Add(addbtn);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 345);
        panel1.Name = "panel1";
        panel1.Size = new Size(750, 91);
        panel1.TabIndex = 1;
        // 
        // deletebtn
        // 
        deletebtn.Anchor = AnchorStyles.None;
        deletebtn.BorderRadius = 5;
        deletebtn.Cursor = Cursors.Hand;
        deletebtn.CustomizableEdges = customizableEdges7;
        deletebtn.DisabledState.BorderColor = Color.DarkGray;
        deletebtn.DisabledState.CustomBorderColor = Color.DarkGray;
        deletebtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        deletebtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        deletebtn.FillColor = Color.FromArgb(220, 38, 38);
        deletebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        deletebtn.ForeColor = Color.White;
        deletebtn.Image = Properties.Resources.trash;
        deletebtn.Location = new Point(525, 21);
        deletebtn.Name = "deletebtn";
        deletebtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
        deletebtn.Size = new Size(168, 45);
        deletebtn.TabIndex = 2;
        deletebtn.Text = "O'chirish";
        deletebtn.Click += deletebtn_Click;
        // 
        // editbtn
        // 
        editbtn.Anchor = AnchorStyles.None;
        editbtn.BorderRadius = 5;
        editbtn.Cursor = Cursors.Hand;
        editbtn.CustomizableEdges = customizableEdges9;
        editbtn.DisabledState.BorderColor = Color.DarkGray;
        editbtn.DisabledState.CustomBorderColor = Color.DarkGray;
        editbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        editbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        editbtn.FillColor = Color.FromArgb(6, 182, 212);
        editbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        editbtn.ForeColor = Color.White;
        editbtn.Image = Properties.Resources.edit;
        editbtn.Location = new Point(288, 21);
        editbtn.Name = "editbtn";
        editbtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
        editbtn.Size = new Size(168, 45);
        editbtn.TabIndex = 1;
        editbtn.Text = "Tahrirlash";
        editbtn.Click += editbtn_Click;
        // 
        // addbtn
        // 
        addbtn.Anchor = AnchorStyles.None;
        addbtn.BorderRadius = 5;
        addbtn.Cursor = Cursors.Hand;
        addbtn.CustomizableEdges = customizableEdges11;
        addbtn.DisabledState.BorderColor = Color.DarkGray;
        addbtn.DisabledState.CustomBorderColor = Color.DarkGray;
        addbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        addbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        addbtn.FillColor = Color.FromArgb(34, 197, 94);
        addbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        addbtn.ForeColor = Color.White;
        addbtn.Image = Properties.Resources.add;
        addbtn.Location = new Point(51, 21);
        addbtn.Name = "addbtn";
        addbtn.ShadowDecoration.CustomizableEdges = customizableEdges12;
        addbtn.Size = new Size(168, 45);
        addbtn.TabIndex = 0;
        addbtn.Text = "Yangi qo'shish";
        addbtn.Click += addbtn_Click;
        // 
        // panel2
        // 
        panel2.Controls.Add(label1);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(750, 50);
        panel2.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(-3, 9);
        label1.Name = "label1";
        label1.Size = new Size(180, 25);
        label1.TabIndex = 0;
        label1.Text = "Mahsulotlar jadvali";
        // 
        // panel3
        // 
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 50);
        panel3.Name = "panel3";
        panel3.Padding = new Padding(30, 0, 30, 0);
        panel3.Size = new Size(750, 295);
        panel3.TabIndex = 3;
        // 
        // ProductTable
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(220, 229, 253);
        Controls.Add(table);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Margin = new Padding(30);
        Name = "ProductTable";
        Size = new Size(750, 436);
        Load += ProductTable_Load;
        ((System.ComponentModel.ISupportInitialize)table).EndInit();
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Guna.UI2.WinForms.Guna2DataGridView table;
    private Panel panel1;
    private Guna.UI2.WinForms.Guna2Button addbtn;
    private Guna.UI2.WinForms.Guna2Button deletebtn;
    private Guna.UI2.WinForms.Guna2Button editbtn;
    private Panel panel2;
    private Label label1;
    private Panel panel3;
}

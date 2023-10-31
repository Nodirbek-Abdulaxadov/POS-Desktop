namespace Desktop.Extended;

partial class Toastr
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
        button1 = new Button();
        message = new Label();
        title = new Label();
        toastTimer = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // button1
        // 
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatAppearance.MouseOverBackColor = Color.Gray;
        button1.FlatStyle = FlatStyle.Popup;
        button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        button1.ForeColor = Color.White;
        button1.Location = new Point(224, -1);
        button1.Name = "button1";
        button1.Size = new Size(35, 23);
        button1.TabIndex = 5;
        button1.Text = "X";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // message
        // 
        message.AutoSize = true;
        message.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        message.ForeColor = Color.White;
        message.Location = new Point(4, 42);
        message.Name = "message";
        message.Size = new Size(117, 21);
        message.TabIndex = 4;
        message.Text = "Error message";
        // 
        // title
        // 
        title.AutoSize = true;
        title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        title.ForeColor = Color.White;
        title.Location = new Point(3, 4);
        title.Name = "title";
        title.Size = new Size(50, 25);
        title.TabIndex = 3;
        title.Text = "Title";
        // 
        // toastTimer
        // 
        toastTimer.Enabled = true;
        toastTimer.Interval = 3000;
        toastTimer.Tick += toastTimer_Tick;
        // 
        // Toastr
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(192, 0, 0);
        ClientSize = new Size(258, 73);
        Controls.Add(button1);
        Controls.Add(message);
        Controls.Add(title);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Toastr";
        Text = "Toastr";
        Load += Toastr_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label message;
    private Label title;
    private System.Windows.Forms.Timer toastTimer;
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Seller;
public partial class Seller : Form
{
    public Seller()
    {
        InitializeComponent();
    }

    private void ChiqishBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

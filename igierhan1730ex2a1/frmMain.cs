using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igierhan1730ex2a1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtDiscountAmount.Text =
            //    (Convert.ToDecimal(txtSubtotal.Text)
            //    * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");
            //txtTotal.Text =
            //    (Convert.ToDecimal(txtSubtotal.Text)
            //    - Convert.ToDecimal(txtDiscountAmount.Text)).ToString("0.00");
            
            decimal Subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal DiscountPercent = Convert.ToDecimal(txtDiscountPercent.Text);
            decimal DiscountAmount = Subtotal * (DiscountPercent / 100);
            txtDiscountAmount.Text = DiscountAmount.ToString("0.00");

            decimal Total = Subtotal - DiscountAmount;
            txtTotal.Text = Total.ToString("0.00");


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

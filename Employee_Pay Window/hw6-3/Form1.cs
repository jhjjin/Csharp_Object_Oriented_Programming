using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw6_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
           
            double totalSale = Convert.ToDouble(txtTotalSales.Text);
            double totalWeekSale = totalSale * 0.07;
            if(totalWeekSale <0)
            {
                MessageBox.Show("Total weekly sales must be a positive dollar amount.\nPlease re-enter.");
            }
            else
            {
                double fedTax = totalWeekSale * 0.18;
                double retirement = totalWeekSale * 0.15;
                double social = totalWeekSale * 0.09;

                txtFederal.Text = Convert.ToString(Math.Round(fedTax,3));
                txtRetirement.Text = Convert.ToString(Math.Round(retirement,3));
                txtSocial.Text = Convert.ToString(Math.Round(social,3));

                double netPay = totalWeekSale - (fedTax + retirement + social);
                txtTotalNet.Text = Convert.ToString(Math.Round(netPay,3));


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtTotalSales.Clear();
            txtFederal.Clear();
            txtRetirement.Clear();
            txtSocial.Clear();  
            txtTotalNet.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

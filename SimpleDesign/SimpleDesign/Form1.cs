using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDesign
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lstFactorial.Items.Clear();
            int n = GetInput(0, txtBox1.Text);
            double est = 1;
            for (int i = 1; i <= n; i++)
            {
                lstfactorial.Items.Add(i.ToString() + "! = " + factorial(i));
                est += 1.0 / factorial(i);
            }
        }
        int GetInput(int low, string y)
        {
            int et;
            bool valid = int.TryParse(y, out et);
            if (!valid)
                MessageBox.Show("Invalid input. Please re-enter a non-negative");
            else if (et < low)
                MessageBox.Show("Invalid input.It has to be no less than 0");
            else
                et = et;
            return et;
        }
        long factorial (int x)
        {
            long fac = 1;
            if (x < 2)
                return 1;
            else
            {
                for (int i = 1; i <= x; i++)
                    fac *= i;
                return fac; 
            }
        }
    }
}

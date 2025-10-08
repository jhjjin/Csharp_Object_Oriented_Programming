using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaOfPentagon
{
    public partial class Calculation : Form
    {
        public Calculation()
        {
            InitializeComponent();
        }

        private void y1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtX1.Clear();
            txtX2.Clear();
            txtX3.Clear();
            txtX4.Clear();
            txtY1.Clear();
            txtY2.Clear();
            txtY3.Clear();
            txtY4.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double x1,x2,x3,x4, x5,y1,y2,y3,y4,y5;
            x1 = Double.Parse(txtX1.Text);
            x2 = Double.Parse(txtX2.Text);
            x3 = Double.Parse(txtX3.Text);
            x4 = Double.Parse(txtX4.Text);
            x5 = Double.Parse(txtX5.Text);
            y1 = Double.Parse(txtY1.Text);
            y2 = Double.Parse(txtY2.Text);
            y3 = Double.Parse(txtY3.Text);
            y4 = Double.Parse(txtY4.Text);
            y5 = Double.Parse(txtY5.Text);

            bool valid1 = double.TryParse(txtX1.Text, out x1);
            if (!valid1)
                MessageBox.Show("Invalid input for x1.");
            bool valid2 = double.TryParse(txtX2.Text, out x2);
            if (!valid2)
                MessageBox.Show("Invalid input for x2.");
            bool valid3 = double.TryParse(txtX3.Text, out x3);
            if (!valid3)
                MessageBox.Show("Invalid input for x3.");
            bool valid4 = double.TryParse(txtX4.Text, out x4);
            if (!valid4)
                MessageBox.Show("Invalid input for x4.");
            bool valid5 = double.TryParse(txtX5.Text, out x5);
            if (!valid5)
                MessageBox.Show("Invalid input for x5.");
            bool valid6 = double.TryParse(txtY1.Text, out y1);
            if (!valid6)
                MessageBox.Show("Invalid input for y1.");
            bool valid7 = double.TryParse(txtY2.Text, out y2);
            if (!valid7)
                MessageBox.Show("Invalid input for y2.");
            bool valid8 = double.TryParse(txtY3.Text, out y3);
            if (!valid8)
                MessageBox.Show("Invalid input for y3.");
            bool valid9 = double.TryParse(txtY4.Text, out y4);
            if (!valid9)
                MessageBox.Show("Invalid input for y4.");
            bool valid10 = double.TryParse(txtY5.Text, out y5);
            if (!valid10)
                MessageBox.Show("Invalid input for y5.");

            double a = Distance2(x1, x2, y1, y2);
            double b = Distance2(x1, x3, y1, y3);
            double c = Distance2(x3, x2, y3, y2);
            double d = Distance2(x3, x5, y3, y5);
            double f = Distance2(x5, x2, y5, y2);
            double c2 = Distance2(x3, x2, y3, y2);
            double g = Distance2(x2, x4, y2, y4);
            double h = Distance2(x4, x5, y5, y4);
            double i = Distance2(x5, x2, y5, y2);

            double t1 = AreaOfTriangle(a,b,c);
            double t2 = AreaOfTriangle(d, f, c2);
            double t3 = AreaOfTriangle(g, h, i);
            double Area = t1 + t2 + t3;
            txtOutput.Text = Area.ToString("0.00");


        }
        public static double AreaOfTriangle(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt((s) * (s - a) * (s - b) * (s - c));
           

        }
        public static double Distance2(double x1, double x2, double y1, double y2)
        {

            return Math.Sqrt((Math.Abs((x1 - x2) * (x1 - x2))) + (Math.Abs((y1 - y2) * (y1 - y2))));
            
        }

        private void Calculation_Load(object sender, EventArgs e)
        {

        }
    }
}

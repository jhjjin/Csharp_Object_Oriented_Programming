using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_21_ECE2310_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numOfStudents = 26;
            int[] score = GenerateRandom(numOfStudents, 60, 100);
            listBox1.Items.Clear();
            listBox1.Items.Add("Student ID#\tScore");
            for (int i = 0; i < numOfStudents; i++)
                listBox1.Items.Add(i.ToString() + "\t\t" + score[i].ToString());
            listBox1.Items.Add("The average score is" + Ave(score).ToString());
            double r = 85.0 / Ave(score);
            if (r < 1) // The average of class is over 85
                MessageBox.Show("The class is doing good");
            else
                MessageBox.Show("Curbe the scores with the ratio of " + r.ToString());

            //double[] newScores = Curved(score, r);
            Curved(score, r); 
            for (int i = 0; i < numOfStudents; i++)
                listBox2.Items.Add(i.ToString() + "\t\t" + score[i].ToString());
        }
        /*double[] Curved(int[] x, double ratio)
        {
            double[] y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i] * ratio;
                y[i] = Math.Round(y[i], 0);
                if (y[i] > 100) y[i] = 100;
            }
            return y;
        }*/
        void Curved(int[] x, double ratio)
        {
            double[] y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i] * ratio;
                y[i] = Math.Round(y[i], 0);
                if (y[i] > 100) y[i] = 100;
                x[i] = Convert.ToInt32(y[i]);
            }
           
        }
        int[] GenerateRandom(int size, int low, int up)
        {
            int[] x = new int[size];
            Random x0 = new Random();
            for (int i = 0; i < size; i++)
                x[i] = x0.Next(low, up + 1);
            return x;
        }
        int Ave(int[] x)
        {
            // ideal  =85 ave 70 ratio = ia/ ave -> x[i] *= i + ratio / cap 100
            int ave = 0;
            for (int i = 0; i < x.Length; i++)
                ave += x[i];
            return ave/x.Length;
            
            
        }
        
    }
}

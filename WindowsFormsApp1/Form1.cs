﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;







namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            float true_wynik = 1000000 / 3;

            Console.Out.WriteLine(m_box.Text);
            int m = int.Parse(m_box.Text);
            int z = int.Parse(z_box.Text);
            Random rnd = new Random();
            int d = 10;
            int l = 100000;
            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = 0;
            single.X2 = 100;
            single.Area = 333333.333;
            for (int j = 0; j < m; j++) {
                
                
                f = 0.0F;
                int licz = 0;
                double old_i = 0;
                double n = rnd.Next(d, l);
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (i * i) * (i - old_i);

                    old_i = i;
                };
                if (single.Area / f > z/100.0) {

                    string wynik = "metoda kwadratów parametry to n=";
                    wynik += n.ToString();
                    wynik += "  wynik to =";
                    wynik += f.ToString();
                    wynik += "\t\t\t";
                    wynik_box.Text += wynik; 
                }
                f = 0.0F;

                n = rnd.Next(d, l);
                old_i = 0;
                for (double i = 0.0F; i <= 100.0; i = i + 100F / n)
                {

                    licz += 1;
                    f += (((i * i) + (old_i *old_i))/2) * (i - old_i);

                    old_i = i;
                };
                if (single.Area / f > z / 100.0)
                {
                    string wynik = "metoda trapezów parametry to n=";
                    wynik += n.ToString();
                    wynik += "  wynik to =";
                    wynik += f.ToString();
                    wynik += "\t\t";
                    wynik_box.Text += wynik;
                }
            }; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

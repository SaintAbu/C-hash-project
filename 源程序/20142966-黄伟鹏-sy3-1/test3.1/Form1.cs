using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3._1
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        bool c = false;
        string d;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void ShowWindows_TextChanged(object sender, EventArgs e)
        {

        }

        private void count1_Click(object sender, EventArgs e)
        {
            if(c==true)
            {
                ShowWindows.Text = "";
                c=false;
            }
            ShowWindows.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                ShowWindows.Text = "";
                c = false;
            }
            ShowWindows.Text += "2";
        }
        private void count3_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                ShowWindows.Text = "";
                c = false;
            }
            ShowWindows.Text += "3";
        }

        private void count4_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                ShowWindows.Text = "";
                c = false;
            }
            ShowWindows.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                ShowWindows.Text = "";
                c = false;
            }
            ShowWindows.Text += "5";
        }

        private void count6_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                ShowWindows.Text = "";
                c = false;
            }
            ShowWindows.Text += "6";
        }

        private void count7_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                ShowWindows.Text = "";
                c = false;
            }
            ShowWindows.Text += "7";
        }

        private void count8_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                ShowWindows.Text = "";
                c = false;
            }
            ShowWindows.Text += "8";
        }

        private void count9_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                ShowWindows.Text = "";
                c = false;
            }
            ShowWindows.Text += "9";
        }

        private void count0_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                ShowWindows.Text = "";
                c = false;
            }
            ShowWindows.Text += "0";
            if (d == "/")
            {
                ShowWindows.Clear();
                MessageBox.Show("除数不能为零", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void counts1_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(ShowWindows.Text);
            d = "+";
        }

        private void counts2_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(ShowWindows.Text);
            d = "-";
        }

        private void counts3_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(ShowWindows.Text);
            d = "*";
        }

        private void counts4_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(ShowWindows.Text);
            d = "/";
        }

        private void counts_Click(object sender, EventArgs e)
        {
            switch (d)
            {
                case "+": a = b + double.Parse(ShowWindows.Text); break;
                case "-": a = b - double.Parse(ShowWindows.Text); break;
                case "*": a = b * double.Parse(ShowWindows.Text); break;
                case "/": a = b / double.Parse(ShowWindows.Text); break;
                case "x^2": a = double.Parse(ShowWindows.Text) * double.Parse(ShowWindows.Text); break;
                case "sqrt": a = Math.Sqrt(double.Parse(ShowWindows.Text)); break;
                case "log": a = Math.Log(double.Parse(ShowWindows.Text),b); break;
                case "ln": a = Math.Log(double.Parse(ShowWindows.Text)); break;
            }
            ShowWindows.Text = a + "";
            c = true;
        }

        private void countc_Click(object sender, EventArgs e)
        {
            ShowWindows.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(ShowWindows.Text);
            d = "x^2";
        }

        private void counts6_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(ShowWindows.Text);
            d = "sqrt";
        }

        private void counts7_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(ShowWindows.Text);
            d = "log";
        }

        private void counts8_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(ShowWindows.Text);
            d = "ln";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrainingApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void bDel_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "+";
            textBox1.Clear();

        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            double answer = 0;
            switch (label2.Text)
            {
                case "+":
                    answer = double.Parse(label1.Text) + double.Parse(textBox1.Text);
                    break;
                case "-":
                    answer = double.Parse(label1.Text) - double.Parse(textBox1.Text);
                    break;
                case "*":
                    answer = double.Parse(label1.Text) * double.Parse(textBox1.Text);
                    break;
                case "/":
                    answer = double.Parse(label1.Text) / double.Parse(textBox1.Text);
                    break;
            }
            textBox1.Text = answer.ToString();
        }

        private void bSubtract_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "-";
            textBox1.Clear();
        }

        private void bMuliply_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "*";
            textBox1.Clear();
        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "/";
            textBox1.Clear();
        }

        private void bBackspace_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void bC_Click_1(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            textBox1.Clear();
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}

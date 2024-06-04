using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingApp
{
    public partial class MathTest : Form
    {
        string[] question = {"ข้อที่ 1) 25 + 40 = ?",
                             "ข้อที่ 2) 48 - 8 = ?",
                             "ข้อที่ 3) 5 * 5 = ?",
                             "ข้อที่ 4) 49 / 7 = ?",
                             "ข้อที่ 5) 8 * 9 = ?"};

        //string[] choice1 = { "80", "40", "50", "6", "74" };
        //string[] choice2 = { "75", "30", "40", "5", "72" };
        //string[] choice3 = { "70", "56", "45", "7", "56" };
        //string[] choice4 = { "65", "42", "25", "8", "81" };

        string[,] choice = { { "80", "75", "70", "65" },
                             { "40", "30", "56", "42" },
                             { "50", "40", "45", "25" },
                             { "6", "5", "7", "8" },
                             { "74", "72", "56", "81" },
                             { "65", "42", "25", "81" } };

        string[] answer = { "65", "40", "25", "7", "72" };

        int n = 0, i = 0;
        public MathTest()
        {
            InitializeComponent();
            showQuestion();

        }
        private void showQuestion()
        {
            label1.Text = question[n];
            radioButton1.Text = choice[n, 0];
            radioButton2.Text = choice[n, 1];
            radioButton3.Text = choice[n, 2];
            radioButton4.Text = choice[n, 3];
            label3.Text = i + " คะแนน";
        }
        private void correctAns()
        {

            string ans = "";
            if (radioButton1.Checked)
                ans = radioButton1.Text;
            else if (radioButton2.Checked)
                ans = radioButton2.Text;
            else if (radioButton3.Checked)
                ans = radioButton3.Text;
            else
                ans = radioButton4.Text;
            if (ans == answer[n])
            {
                i = i + 1;
                MessageBox.Show("ถูกต้อง");
                label3.Text = i + " คะแนน";
            }
            else
                MessageBox.Show("ไม่ถูกต้อง");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            correctAns();

            if (n < question.Length - 1)
            {
                n++;
                showQuestion();
            }
            else
            {
                panel1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจนะว่าจะปืด", "ยืนยัน", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}

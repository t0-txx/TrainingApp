using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrainingApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                name.Focus();
            }
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                salary.Focus();
            }
        }

        private void salary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try 
                {
                    double t = int.Parse(salary.Text) * 0.05;
                    double b = int.Parse(salary.Text) - t;
                    tax.Text = t.ToString("#,##0.00");
                    balance.Text = b.ToString("#,##0.00");
                } 
                catch(Exception ex) 
                {
                    tax.Clear();
                    balance.Clear();
                    MessageBox.Show("ป้อนตัวเลข","Error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ms = "รหัส \t\t=  " + code.Text + "\nชื่อ \t\t=  " + name.Text + "\nเงินเดือน \t\t=  " + salary.Text + "\nหักภาษี 5% \t=  " + tax.Text + "\nคงเหลือ \t\t=  " + balance.Text;
            MessageBox.Show(ms,"ข้อมูลพนักงาน");
        }
    }
}

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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string ms1 , ms2 , ms3 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                ms1 += radioButton1.Text;
            else if (radioButton2.Checked == true)
                ms1 += radioButton2.Text;
            else if (radioButton3.Checked == true)
                ms1 += radioButton3.Text;
            MessageBox.Show(ms1, "น้ำ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                ms2 += "ขนมชั้น\n";
            if (checkBox2.Checked == true)
                ms2 += "ขนมถ้วยฟู\n";
            if (checkBox3.Checked == true)
                ms2 += "ขนมตาล\n";
            if (checkBox4.Checked == true)
                ms2 += "ขนมจ๊อก\n";
            if (checkBox5.Checked == true)
                ms2 += "ขนมใส่ไส้\n";
            MessageBox.Show(ms2, "ขนม");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem + "", "อาหาร");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("น้ำ \n" + ms1 + "\nขนม \n" + ms2  +"อาหาร \n" + comboBox1.SelectedItem, "รายการอาหารที่สั่ง");
        }
    }
}

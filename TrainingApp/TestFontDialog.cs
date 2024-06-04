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
    public partial class TestFontDialog : Form
    {
        public TestFontDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            //MessageBox.Show(this.Controls.Count+"");
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].Font = fontDialog1.Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].ForeColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
            label9.Text = fileInfo.Name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

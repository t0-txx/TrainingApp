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
    public partial class PictureTest : Form
    {
        int i = 0;
        string[] imagList = { "picture (1).jpg", "picture (2).jpg", "picture (3).jpg", "picture (4).jpg", "picture (5).jpg", "picture (6).jpg", "picture (7).jpg", "picture (8).jpg", "picture (9).jpg", "picture (10).jpg" };
        public PictureTest()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = i + 1;
            pictureBox1.Image = System.Drawing.Image.FromFile("F:\\รูป\\" + imagList[i]);
            button1.Enabled = true;
            if (i == imagList.Length - 1)
            {
                button2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = i - 1;
            pictureBox1.Image = System.Drawing.Image.FromFile("F:\\รูป\\" + imagList[i]);
            button2.Enabled = true;
            if (i == 0)
            {
                button1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
        }
    }
}

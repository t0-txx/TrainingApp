namespace TrainingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Visible = false;
        }

        private void itemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemName.Focus();
            }
        }

        private void itemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                price.Focus();
            }
        }

        private void price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                setAmount();
                qty.Focus();
            }
        }

        private void qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setAmount();
            }
        }

        private void setAmount()
        {
            try
            {
                int amt = int.Parse(price.Text) * int.Parse(qty.Text);
                amount.Text = amt.ToString();
            }
            catch (Exception ex)
            {
                amount.Clear();
                MessageBox.Show("ป้อนราคาหรือจำนวนไม่ถูกต้อง", "ข้อมูลผิดพลาด");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ms = "รหัส \t=   " + itemCode.Text + "\nชื่อ \t=   " + itemName.Text + "\nราคา \t=   " + price.Text + "\nจำนวน \t=   " + qty.Text + "\nเป็นเงิน \t=   " + amount.Text;
            MessageBox.Show(ms, "ข้อมูลสินค้า");
        }
    }
}
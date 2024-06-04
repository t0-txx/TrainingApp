namespace TrainingApp
{
    partial class TestFontDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            amount = new TextBox();
            label5 = new Label();
            qty = new TextBox();
            label4 = new Label();
            price = new TextBox();
            label3 = new Label();
            itemName = new TextBox();
            label2 = new Label();
            itemCode = new TextBox();
            label1 = new Label();
            button1 = new Button();
            fontDialog1 = new FontDialog();
            panel1 = new Panel();
            button2 = new Button();
            colorDialog1 = new ColorDialog();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            button4 = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(217, 186);
            label8.Name = "label8";
            label8.Size = new Size(35, 21);
            label8.TabIndex = 0;
            label8.Text = "บาท";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(222, 151);
            label7.Name = "label7";
            label7.Size = new Size(30, 21);
            label7.TabIndex = 0;
            label7.Text = "ชิ้น";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(217, 116);
            label6.Name = "label6";
            label6.Size = new Size(35, 21);
            label6.TabIndex = 0;
            label6.Text = "บาท";
            // 
            // amount
            // 
            amount.Enabled = false;
            amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amount.Location = new Point(107, 178);
            amount.Name = "amount";
            amount.Size = new Size(100, 29);
            amount.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 186);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 0;
            label5.Text = "เป็นเงิน";
            // 
            // qty
            // 
            qty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            qty.Location = new Point(107, 143);
            qty.Name = "qty";
            qty.Size = new Size(100, 29);
            qty.TabIndex = 4;
            qty.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 151);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 0;
            label4.Text = "จำนวน";
            // 
            // price
            // 
            price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(107, 108);
            price.Name = "price";
            price.Size = new Size(100, 29);
            price.TabIndex = 3;
            price.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 116);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 0;
            label3.Text = "ราคา";
            // 
            // itemName
            // 
            itemName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemName.Location = new Point(107, 73);
            itemName.Name = "itemName";
            itemName.Size = new Size(186, 29);
            itemName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 81);
            label2.Name = "label2";
            label2.Size = new Size(28, 21);
            label2.TabIndex = 0;
            label2.Text = "ชื่อ";
            // 
            // itemCode
            // 
            itemCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemCode.Location = new Point(107, 38);
            itemCode.MaxLength = 4;
            itemCode.Name = "itemCode";
            itemCode.Size = new Size(186, 29);
            itemCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 46);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 0;
            label1.Text = "รหัส";
            // 
            // button1
            // 
            button1.Location = new Point(40, 316);
            button1.Name = "button1";
            button1.Size = new Size(317, 29);
            button1.TabIndex = 6;
            button1.Text = "Font";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(amount);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(qty);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(price);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(itemName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(itemCode);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(40, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 247);
            panel1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(40, 351);
            button2.Name = "button2";
            button2.Size = new Size(317, 23);
            button2.TabIndex = 8;
            button2.Text = "Color";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(40, 380);
            button3.Name = "button3";
            button3.Size = new Size(317, 23);
            button3.TabIndex = 9;
            button3.Text = "BackColor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(388, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 247);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(548, 316);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 11;
            label9.Text = "ไฟล์";
            // 
            // button4
            // 
            button4.Location = new Point(388, 351);
            button4.Name = "button4";
            button4.Size = new Size(349, 23);
            button4.TabIndex = 12;
            button4.Text = "Browse";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // TestFontDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "TestFontDialog";
            Text = "TestFontDialog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox amount;
        private Label label5;
        private TextBox qty;
        private Label label4;
        private TextBox price;
        private Label label3;
        private TextBox itemName;
        private Label label2;
        private TextBox itemCode;
        private Label label1;
        private Button button1;
        private FontDialog fontDialog1;
        private Panel panel1;
        private Button button2;
        private ColorDialog colorDialog1;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label9;
        private Button button4;
        private OpenFileDialog openFileDialog1;
    }
}
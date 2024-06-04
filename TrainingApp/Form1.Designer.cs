namespace TrainingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            itemCode = new TextBox();
            itemName = new TextBox();
            label2 = new Label();
            price = new TextBox();
            label3 = new Label();
            qty = new TextBox();
            label4 = new Label();
            amount = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(153, 101);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 0;
            label1.Text = "รหัส";
            // 
            // itemCode
            // 
            itemCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemCode.Location = new Point(229, 93);
            itemCode.MaxLength = 4;
            itemCode.Name = "itemCode";
            itemCode.Size = new Size(186, 29);
            itemCode.TabIndex = 1;
            itemCode.KeyDown += itemCode_KeyDown;
            // 
            // itemName
            // 
            itemName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemName.Location = new Point(229, 128);
            itemName.Name = "itemName";
            itemName.Size = new Size(186, 29);
            itemName.TabIndex = 3;
            itemName.KeyDown += itemName_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(153, 136);
            label2.Name = "label2";
            label2.Size = new Size(28, 21);
            label2.TabIndex = 2;
            label2.Text = "ชื่อ";
            // 
            // price
            // 
            price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(229, 163);
            price.Name = "price";
            price.Size = new Size(100, 29);
            price.TabIndex = 5;
            price.Text = "0";
            price.KeyDown += price_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(153, 171);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 4;
            label3.Text = "ราคา";
            // 
            // qty
            // 
            qty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            qty.Location = new Point(229, 198);
            qty.Name = "qty";
            qty.Size = new Size(100, 29);
            qty.TabIndex = 7;
            qty.Text = "0";
            qty.KeyDown += qty_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(153, 206);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 6;
            label4.Text = "จำนวน";
            // 
            // amount
            // 
            amount.Enabled = false;
            amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amount.Location = new Point(229, 233);
            amount.Name = "amount";
            amount.Size = new Size(100, 29);
            amount.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(153, 241);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 8;
            label5.Text = "เป็นเงิน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(339, 171);
            label6.Name = "label6";
            label6.Size = new Size(35, 21);
            label6.TabIndex = 10;
            label6.Text = "บาท";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(344, 206);
            label7.Name = "label7";
            label7.Size = new Size(30, 21);
            label7.TabIndex = 11;
            label7.Text = "ชิ้น";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(339, 241);
            label8.Name = "label8";
            label8.Size = new Size(35, 21);
            label8.TabIndex = 12;
            label8.Text = "บาท";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(229, 269);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(186, 64);
            textBox6.TabIndex = 14;
            textBox6.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(153, 269);
            button1.Name = "button1";
            button1.Size = new Size(70, 29);
            button1.TabIndex = 15;
            button1.Text = "แสดง";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(153, 304);
            button2.Name = "button2";
            button2.Size = new Size(70, 29);
            button2.TabIndex = 16;
            button2.Text = "ซ่อน";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(435, 93);
            button3.Name = "button3";
            button3.Size = new Size(113, 239);
            button3.TabIndex = 17;
            button3.Text = "Show Data";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Control;
            ClientSize = new Size(679, 437);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(amount);
            Controls.Add(label5);
            Controls.Add(qty);
            Controls.Add(label4);
            Controls.Add(price);
            Controls.Add(label3);
            Controls.Add(itemName);
            Controls.Add(label2);
            Controls.Add(itemCode);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox itemCode;
        private TextBox itemName;
        private Label label2;
        private TextBox price;
        private Label label3;
        private TextBox qty;
        private Label label4;
        private TextBox amount;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
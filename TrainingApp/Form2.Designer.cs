namespace TrainingApp
{
    partial class Form2
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
            label1 = new Label();
            code = new TextBox();
            name = new TextBox();
            label2 = new Label();
            salary = new TextBox();
            label3 = new Label();
            tax = new TextBox();
            label4 = new Label();
            balance = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 149);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "รหัส";
            // 
            // code
            // 
            code.Location = new Point(292, 146);
            code.Name = "code";
            code.Size = new Size(100, 23);
            code.TabIndex = 1;
            code.KeyDown += code_KeyDown;
            // 
            // name
            // 
            name.Location = new Point(292, 175);
            name.Name = "name";
            name.Size = new Size(175, 23);
            name.TabIndex = 3;
            name.KeyDown += name_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 178);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 2;
            label2.Text = "ชื่อ";
            // 
            // salary
            // 
            salary.Location = new Point(292, 204);
            salary.Name = "salary";
            salary.Size = new Size(100, 23);
            salary.TabIndex = 5;
            salary.KeyDown += salary_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 207);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "เงินเดือน";
            // 
            // tax
            // 
            tax.Enabled = false;
            tax.Location = new Point(292, 233);
            tax.Name = "tax";
            tax.Size = new Size(100, 23);
            tax.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 236);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "หักภาษี 5%";
            // 
            // balance
            // 
            balance.Enabled = false;
            balance.Location = new Point(292, 262);
            balance.Name = "balance";
            balance.Size = new Size(100, 23);
            balance.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 265);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 8;
            label5.Text = "คงเหลือ";
            // 
            // button1
            // 
            button1.Location = new Point(482, 146);
            button1.Name = "button1";
            button1.Size = new Size(104, 139);
            button1.TabIndex = 10;
            button1.Text = "แสดงข้อมูล";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(balance);
            Controls.Add(label5);
            Controls.Add(tax);
            Controls.Add(label4);
            Controls.Add(salary);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(code);
            Controls.Add(label1);
            Name = "Form2";
            Text = "ข้อมูลพนักงาน";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox code;
        private TextBox name;
        private Label label2;
        private TextBox salary;
        private Label label3;
        private TextBox tax;
        private Label label4;
        private TextBox balance;
        private Label label5;
        private Button button1;
    }
}
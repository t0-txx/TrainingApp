﻿namespace TrainingApp
{
    partial class Dialogform
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
            fontDialog1 = new FontDialog();
            button1 = new Button();
            button2 = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(377, 142);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "วีระชัย รุ่งโรจน์ประชาชื่น";
            // 
            // button1
            // 
            button1.Location = new Point(377, 245);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 1;
            button1.Text = "Font";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(377, 274);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 2;
            button2.Text = "Color";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Dialogform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Dialogform";
            Text = "ทดสอบ Font & Color Dialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontDialog fontDialog1;
        private Button button1;
        private Button button2;
        private ColorDialog colorDialog1;
    }
}
﻿namespace Döngüler
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(59, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 256);
            this.listBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Topla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(460, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(436, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Çift Topla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 28;
            this.listBox2.Location = new System.Drawing.Point(621, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(251, 256);
            this.listBox2.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(671, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 93);
            this.button4.TabIndex = 6;
            this.button4.Text = "ikiye Bölünenler";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(282, 402);
            this.maskedTextBox1.Mask = "000000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(116, 36);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 28;
            this.listBox3.Location = new System.Drawing.Point(404, 358);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(217, 116);
            this.listBox3.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(279, 480);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(342, 51);
            this.button5.TabIndex = 10;
            this.button5.Text = "Tam Bölenlerini Al";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(929, 609);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button5;
    }
}


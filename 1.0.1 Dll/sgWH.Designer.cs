﻿namespace Dll1
{
    partial class sgWH
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
            this.button2 = new System.Windows.Forms.Button();
            this.WHWT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XL = new System.Windows.Forms.TextBox();
            this.YL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WHWT
            // 
            this.WHWT.AutoSize = true;
            this.WHWT.Location = new System.Drawing.Point(60, 41);
            this.WHWT.Name = "WHWT";
            this.WHWT.Size = new System.Drawing.Size(0, 12);
            this.WHWT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // XL
            // 
            this.XL.Location = new System.Drawing.Point(116, 74);
            this.XL.Name = "XL";
            this.XL.Size = new System.Drawing.Size(100, 21);
            this.XL.TabIndex = 5;
            // 
            // YL
            // 
            this.YL.Location = new System.Drawing.Point(116, 141);
            this.YL.Name = "YL";
            this.YL.Size = new System.Drawing.Size(100, 21);
            this.YL.TabIndex = 6;
            // 
            // sgWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.YL);
            this.Controls.Add(this.XL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WHWT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "sgWH";
            this.Text = "设置坐标";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label WHWT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox XL;
        private System.Windows.Forms.TextBox YL;
    }
}
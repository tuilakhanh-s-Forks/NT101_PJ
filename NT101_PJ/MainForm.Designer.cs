﻿namespace NT101_PJ
{
    partial class MainForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnRSA = new Button();
            btPlayFair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 17);
            label1.Name = "label1";
            label1.Size = new Size(243, 37);
            label1.TabIndex = 0;
            label1.Text = "ĐỒ ÁN MÔN HỌC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 68);
            label2.Name = "label2";
            label2.Size = new Size(507, 50);
            label2.TabIndex = 1;
            label2.Text = "AN TOÀN MẠNG MÁY TÍNH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(178, 129);
            label3.Name = "label3";
            label3.Size = new Size(465, 37);
            label3.TabIndex = 2;
            label3.Text = "NHÓM: 06, LỚP: NT101.O12.MMCL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(221, 178);
            label4.Name = "label4";
            label4.Size = new Size(371, 37);
            label4.TabIndex = 3;
            label4.Text = "Các thành viên trong nhóm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(268, 239);
            label5.Name = "label5";
            label5.Size = new Size(275, 30);
            label5.TabIndex = 4;
            label5.Text = "Lê Hoàng Khánh - 21522205";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(268, 269);
            label6.Name = "label6";
            label6.Size = new Size(297, 30);
            label6.TabIndex = 5;
            label6.Text = "Nguyễn Đình Khoa - 21522227";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(268, 299);
            label7.Name = "label7";
            label7.Size = new Size(240, 30);
            label7.TabIndex = 6;
            label7.Text = "Lê Xuân Linh - 21522286";
            // 
            // btnRSA
            // 
            btnRSA.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRSA.ForeColor = Color.Red;
            btnRSA.Location = new Point(241, 353);
            btnRSA.Name = "btnRSA";
            btnRSA.Size = new Size(112, 68);
            btnRSA.TabIndex = 7;
            btnRSA.Text = "RSA";
            btnRSA.UseVisualStyleBackColor = true;
            // 
            // btPlayFair
            // 
            btPlayFair.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPlayFair.ForeColor = Color.Red;
            btPlayFair.Location = new Point(453, 353);
            btPlayFair.Name = "btPlayFair";
            btPlayFair.Size = new Size(112, 68);
            btPlayFair.TabIndex = 8;
            btPlayFair.Text = "PlayFair";
            btPlayFair.UseVisualStyleBackColor = true;
            btPlayFair.Click += btPlayFair_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btPlayFair);
            Controls.Add(btnRSA);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnRSA;
        private Button btPlayFair;
    }
}

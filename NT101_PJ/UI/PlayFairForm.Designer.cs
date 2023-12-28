namespace NT101_PJ
{
    partial class PlayFairForm
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
            groupBox1 = new GroupBox();
            btInitialMatrix = new Button();
            btSubmit = new Button();
            groupBox3 = new GroupBox();
            rbt6x6 = new RadioButton();
            rbt5x5 = new RadioButton();
            panel1 = new Panel();
            txtKey = new TextBox();
            txtMessage = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtResult = new TextBox();
            label3 = new Label();
            btEncrypt = new Button();
            btClear = new Button();
            btSwap = new Button();
            btDecrypt = new Button();
            btExit = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btInitialMatrix);
            groupBox1.Controls.Add(btSubmit);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(txtKey);
            groupBox1.Controls.Add(txtMessage);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // btInitialMatrix
            // 
            btInitialMatrix.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btInitialMatrix.Location = new Point(246, 388);
            btInitialMatrix.Name = "btInitialMatrix";
            btInitialMatrix.Size = new Size(139, 23);
            btInitialMatrix.TabIndex = 8;
            btInitialMatrix.Text = "Initial Matrix";
            btInitialMatrix.UseVisualStyleBackColor = true;
            btInitialMatrix.Click += btInitialMatrix_Click;
            // 
            // btSubmit
            // 
            btSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSubmit.Location = new Point(246, 358);
            btSubmit.Name = "btSubmit";
            btSubmit.Size = new Size(139, 23);
            btSubmit.TabIndex = 7;
            btSubmit.Text = "Submit";
            btSubmit.UseVisualStyleBackColor = true;
            btSubmit.Click += btSubmit_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbt6x6);
            groupBox3.Controls.Add(rbt5x5);
            groupBox3.Location = new Point(256, 243);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(118, 100);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Matrix";
            // 
            // rbt6x6
            // 
            rbt6x6.AutoSize = true;
            rbt6x6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbt6x6.Location = new Point(32, 60);
            rbt6x6.Name = "rbt6x6";
            rbt6x6.Size = new Size(52, 19);
            rbt6x6.TabIndex = 1;
            rbt6x6.TabStop = true;
            rbt6x6.Text = "6 x 6";
            rbt6x6.UseVisualStyleBackColor = true;
            // 
            // rbt5x5
            // 
            rbt5x5.AutoSize = true;
            rbt5x5.Checked = true;
            rbt5x5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbt5x5.Location = new Point(32, 35);
            rbt5x5.Name = "rbt5x5";
            rbt5x5.Size = new Size(52, 19);
            rbt5x5.TabIndex = 0;
            rbt5x5.TabStop = true;
            rbt5x5.Text = "5 x 5";
            rbt5x5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(22, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 201);
            panel1.TabIndex = 5;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(6, 175);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(379, 23);
            txtKey.TabIndex = 3;
            txtKey.TextChanged += txtKey_TextChanged;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(6, 42);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ScrollBars = ScrollBars.Vertical;
            txtMessage.Size = new Size(379, 98);
            txtMessage.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 150);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Message";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtResult);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(409, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 343);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(6, 42);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(367, 295);
            txtResult.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 18);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 1;
            label3.Text = "Result";
            // 
            // btEncrypt
            // 
            btEncrypt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEncrypt.Location = new Point(464, 362);
            btEncrypt.Name = "btEncrypt";
            btEncrypt.Size = new Size(64, 53);
            btEncrypt.TabIndex = 8;
            btEncrypt.Text = "Encrypt";
            btEncrypt.UseVisualStyleBackColor = true;
            btEncrypt.Click += btEncrypt_Click;
            // 
            // btClear
            // 
            btClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClear.Location = new Point(674, 362);
            btClear.Name = "btClear";
            btClear.Size = new Size(64, 53);
            btClear.TabIndex = 9;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btSwap
            // 
            btSwap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSwap.Location = new Point(604, 362);
            btSwap.Name = "btSwap";
            btSwap.Size = new Size(64, 53);
            btSwap.TabIndex = 11;
            btSwap.Text = "Swap To Decrypt";
            btSwap.UseVisualStyleBackColor = true;
            btSwap.Click += btSwap_Click;
            // 
            // btDecrypt
            // 
            btDecrypt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDecrypt.Location = new Point(534, 362);
            btDecrypt.Name = "btDecrypt";
            btDecrypt.Size = new Size(64, 53);
            btDecrypt.TabIndex = 12;
            btDecrypt.Text = "Decrypt";
            btDecrypt.UseVisualStyleBackColor = true;
            btDecrypt.Click += btDecrypt_Click;
            // 
            // btExit
            // 
            btExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(568, 421);
            btExit.Name = "btExit";
            btExit.Size = new Size(64, 23);
            btExit.TabIndex = 8;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // PlayFairForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btExit);
            Controls.Add(btDecrypt);
            Controls.Add(btSwap);
            Controls.Add(btClear);
            Controls.Add(btEncrypt);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PlayFairForm";
            Text = "Play Fair";
            FormClosed += PlayFairForm_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtKey;
        private TextBox txtMessage;
        private Button btSubmit;
        private GroupBox groupBox3;
        private RadioButton rbt6x6;
        private RadioButton rbt5x5;
        private Panel panel1;
        private TextBox txtResult;
        private Label label3;
        private Button btEncrypt;
        private Button btClear;
        private Button btSwap;
        private Button btDecrypt;
        private Button btExit;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btInitialMatrix;
    }
}
namespace NT101_PJ
{
    partial class RSAForm
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
            richTextBoxInput = new RichTextBox();
            groupBoxInput = new GroupBox();
            groupBoxOutput = new GroupBox();
            richTextBoxOutput = new RichTextBox();
            richTextBoxPublic = new RichTextBox();
            richTextBoxPrivate = new RichTextBox();
            labelPublicKey = new Label();
            labelPrivateKey = new Label();
            comboBoxKeySize = new ComboBox();
            labelKeySize = new Label();
            buttonOpenPublic = new Button();
            buttonOpenPrivate = new Button();
            buttonGenerate = new Button();
            groupBoxKey = new GroupBox();
            labelPadding = new Label();
            comboBoxPadding = new ComboBox();
            buttonSavePrivate = new Button();
            buttonSavePublic = new Button();
            buttonImport = new Button();
            buttonReset = new Button();
            buttonEncrypt = new Button();
            buttonDecrypt = new Button();
            buttonSwap = new Button();
            labelRSA = new Label();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            groupBoxKey.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxInput
            // 
            richTextBoxInput.Font = new Font("Segoe UI", 12F);
            richTextBoxInput.Location = new Point(6, 22);
            richTextBoxInput.Name = "richTextBoxInput";
            richTextBoxInput.Size = new Size(551, 180);
            richTextBoxInput.TabIndex = 0;
            richTextBoxInput.Text = "";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(richTextBoxInput);
            groupBoxInput.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxInput.Location = new Point(634, 81);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(563, 208);
            groupBoxInput.TabIndex = 2;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Input";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(richTextBoxOutput);
            groupBoxOutput.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxOutput.Location = new Point(634, 304);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(554, 223);
            groupBoxOutput.TabIndex = 3;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Output";
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.Font = new Font("Segoe UI", 12F);
            richTextBoxOutput.Location = new Point(6, 22);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.Size = new Size(542, 195);
            richTextBoxOutput.TabIndex = 0;
            richTextBoxOutput.Text = "";
            // 
            // richTextBoxPublic
            // 
            richTextBoxPublic.Font = new Font("Segoe UI", 12F);
            richTextBoxPublic.Location = new Point(16, 130);
            richTextBoxPublic.Name = "richTextBoxPublic";
            richTextBoxPublic.Size = new Size(548, 134);
            richTextBoxPublic.TabIndex = 4;
            richTextBoxPublic.Text = "";
            // 
            // richTextBoxPrivate
            // 
            richTextBoxPrivate.Font = new Font("Segoe UI", 12F);
            richTextBoxPrivate.Location = new Point(16, 347);
            richTextBoxPrivate.Name = "richTextBoxPrivate";
            richTextBoxPrivate.Size = new Size(548, 134);
            richTextBoxPrivate.TabIndex = 5;
            richTextBoxPrivate.Text = "";
            // 
            // labelPublicKey
            // 
            labelPublicKey.AutoSize = true;
            labelPublicKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPublicKey.Location = new Point(16, 106);
            labelPublicKey.Name = "labelPublicKey";
            labelPublicKey.Size = new Size(165, 21);
            labelPublicKey.TabIndex = 6;
            labelPublicKey.Text = "RSA Public Key (PEM)";
            // 
            // labelPrivateKey
            // 
            labelPrivateKey.AutoSize = true;
            labelPrivateKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrivateKey.Location = new Point(16, 323);
            labelPrivateKey.Name = "labelPrivateKey";
            labelPrivateKey.Size = new Size(171, 21);
            labelPrivateKey.TabIndex = 7;
            labelPrivateKey.Text = "RSA Private Key (PEM)";
            // 
            // comboBoxKeySize
            // 
            comboBoxKeySize.Font = new Font("Segoe UI", 12F);
            comboBoxKeySize.FormattingEnabled = true;
            comboBoxKeySize.Location = new Point(89, 28);
            comboBoxKeySize.Name = "comboBoxKeySize";
            comboBoxKeySize.Size = new Size(199, 29);
            comboBoxKeySize.TabIndex = 8;
            // 
            // labelKeySize
            // 
            labelKeySize.AutoSize = true;
            labelKeySize.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKeySize.Location = new Point(16, 31);
            labelKeySize.Name = "labelKeySize";
            labelKeySize.Size = new Size(70, 21);
            labelKeySize.TabIndex = 9;
            labelKeySize.Text = "Key Size";
            // 
            // buttonOpenPublic
            // 
            buttonOpenPublic.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOpenPublic.Location = new Point(382, 96);
            buttonOpenPublic.Name = "buttonOpenPublic";
            buttonOpenPublic.Size = new Size(88, 28);
            buttonOpenPublic.TabIndex = 10;
            buttonOpenPublic.Text = "Open";
            buttonOpenPublic.UseVisualStyleBackColor = true;
            buttonOpenPublic.Click += buttonOpenPublic_Click;
            // 
            // buttonOpenPrivate
            // 
            buttonOpenPrivate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOpenPrivate.Location = new Point(382, 313);
            buttonOpenPrivate.Name = "buttonOpenPrivate";
            buttonOpenPrivate.Size = new Size(88, 28);
            buttonOpenPrivate.TabIndex = 11;
            buttonOpenPrivate.Text = "Open";
            buttonOpenPrivate.UseVisualStyleBackColor = true;
            buttonOpenPrivate.Click += buttonOpenPrivate_Click;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGenerate.Location = new Point(308, 44);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(88, 29);
            buttonGenerate.TabIndex = 12;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // groupBoxKey
            // 
            groupBoxKey.Controls.Add(labelPadding);
            groupBoxKey.Controls.Add(comboBoxPadding);
            groupBoxKey.Controls.Add(buttonSavePrivate);
            groupBoxKey.Controls.Add(buttonSavePublic);
            groupBoxKey.Controls.Add(buttonImport);
            groupBoxKey.Controls.Add(richTextBoxPublic);
            groupBoxKey.Controls.Add(buttonGenerate);
            groupBoxKey.Controls.Add(richTextBoxPrivate);
            groupBoxKey.Controls.Add(buttonOpenPrivate);
            groupBoxKey.Controls.Add(labelPublicKey);
            groupBoxKey.Controls.Add(buttonOpenPublic);
            groupBoxKey.Controls.Add(labelPrivateKey);
            groupBoxKey.Controls.Add(labelKeySize);
            groupBoxKey.Controls.Add(comboBoxKeySize);
            groupBoxKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxKey.Location = new Point(12, 81);
            groupBoxKey.Name = "groupBoxKey";
            groupBoxKey.Size = new Size(581, 495);
            groupBoxKey.TabIndex = 13;
            groupBoxKey.TabStop = false;
            groupBoxKey.Text = "Key";
            // 
            // labelPadding
            // 
            labelPadding.AutoSize = true;
            labelPadding.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPadding.Location = new Point(16, 66);
            labelPadding.Name = "labelPadding";
            labelPadding.Size = new Size(70, 21);
            labelPadding.TabIndex = 20;
            labelPadding.Text = "Padding";
            // 
            // comboBoxPadding
            // 
            comboBoxPadding.Font = new Font("Segoe UI", 12F);
            comboBoxPadding.FormattingEnabled = true;
            comboBoxPadding.Location = new Point(89, 63);
            comboBoxPadding.Name = "comboBoxPadding";
            comboBoxPadding.Size = new Size(199, 29);
            comboBoxPadding.TabIndex = 19;
            // 
            // buttonSavePrivate
            // 
            buttonSavePrivate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSavePrivate.Location = new Point(476, 313);
            buttonSavePrivate.Name = "buttonSavePrivate";
            buttonSavePrivate.Size = new Size(88, 28);
            buttonSavePrivate.TabIndex = 18;
            buttonSavePrivate.Text = "Save";
            buttonSavePrivate.UseVisualStyleBackColor = true;
            buttonSavePrivate.Click += buttonSavePrivate_Click;
            // 
            // buttonSavePublic
            // 
            buttonSavePublic.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSavePublic.Location = new Point(476, 96);
            buttonSavePublic.Name = "buttonSavePublic";
            buttonSavePublic.Size = new Size(88, 28);
            buttonSavePublic.TabIndex = 17;
            buttonSavePublic.Text = "Save";
            buttonSavePublic.UseVisualStyleBackColor = true;
            buttonSavePublic.Click += buttonSavePublic_Click;
            // 
            // buttonImport
            // 
            buttonImport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonImport.Location = new Point(424, 43);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(88, 30);
            buttonImport.TabIndex = 13;
            buttonImport.Text = "Import";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(1108, 30);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(89, 32);
            buttonReset.TabIndex = 14;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEncrypt.Location = new Point(829, 541);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(88, 35);
            buttonEncrypt.TabIndex = 15;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDecrypt.Location = new Point(938, 541);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(88, 35);
            buttonDecrypt.TabIndex = 16;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // buttonSwap
            // 
            buttonSwap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSwap.Location = new Point(1103, 541);
            buttonSwap.Name = "buttonSwap";
            buttonSwap.Size = new Size(88, 35);
            buttonSwap.TabIndex = 17;
            buttonSwap.Text = "Swap";
            buttonSwap.UseVisualStyleBackColor = true;
            buttonSwap.Click += buttonSwap_Click;
            // 
            // labelRSA
            // 
            labelRSA.AutoSize = true;
            labelRSA.Font = new Font("UVN Chim Bien Nang", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRSA.Location = new Point(488, 21);
            labelRSA.Name = "labelRSA";
            labelRSA.Size = new Size(266, 41);
            labelRSA.TabIndex = 18;
            labelRSA.Text = "RSA CryptoSystem";
            // 
            // RSAForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 595);
            Controls.Add(labelRSA);
            Controls.Add(buttonSwap);
            Controls.Add(buttonDecrypt);
            Controls.Add(buttonEncrypt);
            Controls.Add(buttonReset);
            Controls.Add(groupBoxKey);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Name = "RSAForm";
            Text = "RSA";
            FormClosed += RSAForm_FormClosed;
            Load += RSAForm_Load;
            groupBoxInput.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            groupBoxKey.ResumeLayout(false);
            groupBoxKey.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxInput;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxOutput;
        private RichTextBox richTextBoxOutput;
        private RichTextBox richTextBoxPublic;
        private RichTextBox richTextBoxPrivate;
        private Label labelPublicKey;
        private Label labelPrivateKey;
        private ComboBox comboBoxKeySize;
        private Label labelKeySize;
        private Button buttonOpenPublic;
        private Button buttonOpenPrivate;
        private Button buttonGenerate;
        private GroupBox groupBoxKey;
        private Button buttonImport;
        private Button buttonReset;
        private Button buttonEncrypt;
        private Button buttonDecrypt;
        private Button buttonSavePublic;
        private Button buttonSavePrivate;
        private Button buttonSwap;
        private Label labelPadding;
        private ComboBox comboBoxPadding;
        private Label labelRSA;
    }
}
using NT101_PJ.Crypto;
using System.Security.Cryptography;

namespace NT101_PJ
{
    public partial class RSAForm : Form
    {
        private RSAHealper _rsa;
        private int _key_size;

        public RSAForm()
        {
            InitializeComponent();
        }

        private void RSAForm_Load(object sender, EventArgs e)
        {
            comboBoxKeySize.Items.Clear();
            comboBoxKeySize.DataSource = Enum.GetValues(typeof(KeySize));
            comboBoxPadding.Items.AddRange(new object[]
            {
                RSAEncryptionPadding.Pkcs1,
                RSAEncryptionPadding.OaepSHA1,
                RSAEncryptionPadding.OaepSHA256,
                RSAEncryptionPadding.OaepSHA384,
                RSAEncryptionPadding.OaepSHA512
            });
            comboBoxPadding.SelectedIndex = 0;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (comboBoxKeySize.SelectedItem == null)
            {
                MessageBox.Show("Please sellect Key Size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _key_size = (int)comboBoxKeySize.SelectedItem;
            _rsa = new RSAHealper(_key_size);
            richTextBoxPublic.Text = _rsa.PublicKeyExport();
            richTextBoxPrivate.Text = _rsa.PrivateKeyExport();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (_rsa == null)
            {
                MessageBox.Show("Please generate or import Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Input = richTextBoxInput.Text;
            if (string.IsNullOrEmpty(Input))
            {
                return;
            }
            string Output = _rsa.Encrypt(Input, (RSAEncryptionPadding)comboBoxPadding.SelectedItem);
            richTextBoxOutput.Text = Output;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (_rsa == null)
            {
                MessageBox.Show("Please generate or import Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Input = richTextBoxInput.Text;
            if (string.IsNullOrEmpty(Input))
            {
                return;
            }
            try
            {
                string Output = _rsa.Decrypt(Input, (RSAEncryptionPadding)comboBoxPadding.SelectedItem);
                richTextBoxOutput.Text = Output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSavePublic_Click(object sender, EventArgs e)
        {
            string content = richTextBoxPublic.Text;
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Please generate or import Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "PEM Files (*.pem)|*.pem|All Files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, content);
                MessageBox.Show("Public Key saved successfully!");
            }
        }

        private void buttonSavePrivate_Click(object sender, EventArgs e)
        {
            string content = richTextBoxPrivate.Text;
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Please generate or import Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "PEM Files (*.pem)|*.pem|All Files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, content);
                MessageBox.Show("Private Key saved successfully!");
            }
        }

        private void buttonOpenPublic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "PEM Files (*.pem)|*.pem|All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                richTextBoxPublic.Text = File.ReadAllText(filePath);
            }
        }

        private void buttonOpenPrivate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "PEM Files (*.pem)|*.pem|All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                richTextBoxPrivate.Text = File.ReadAllText(filePath);
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            string publicKey = richTextBoxPublic.Text;
            string privateKey = richTextBoxPrivate.Text;
            if (!publicKey.Contains("-----BEGIN RSA PUBLIC KEY-----") && !string.IsNullOrEmpty(publicKey))
            {
                MessageBox.Show("Public Key is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!privateKey.Contains("-----BEGIN RSA PRIVATE KEY-----") && !string.IsNullOrEmpty(privateKey))
            {
                MessageBox.Show("Private Key is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _rsa = new RSAHealper(publicKey, privateKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Import key successfully!");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _rsa.Dispose();
            _rsa = null;
            richTextBoxInput.Text = string.Empty;
            richTextBoxOutput.Text = string.Empty;
            richTextBoxPublic.Text = string.Empty;
            richTextBoxPrivate.Text = string.Empty;
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            richTextBoxInput.Text = richTextBoxOutput.Text;
            richTextBoxOutput.Text = string.Empty;
        }
    }
}

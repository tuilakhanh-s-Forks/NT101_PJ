using System.Data;
using System.Text.RegularExpressions;
using Unidecode.NET;

namespace NT101_PJ
{
    public partial class PlayFairForm : Form
    {
        private int check = 5;
        private Button[,] arrayMatrix = new Button[6, 6];
        private List<string> alphabet = new List<string>();

        public PlayFairForm()
        {
            InitializeComponent();
            InitMatrix(5);
            txtKey.KeyPress += Matrix5_KeyPress;
            rbt5x5.CheckedChanged += RadioButtons_CheckedChanged;
            rbt6x6.CheckedChanged += RadioButtons_CheckedChanged;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string PreparePlainText(int size)
        {
            string text = txtMessage.Text?.Trim();
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            string plainText = text.Unidecode().ToUpperInvariant();

            Regex regex = size == 5
                ? new Regex(@"[\W\d]")
                : new Regex(@"[\W]"); 
            plainText = regex.Replace(plainText, string.Empty);

            plainText = plainText.Replace("J", "I");

            return plainText.Length % 2 == 0 ? plainText : plainText + "X";
        }

        private string DistinctString(string input)
        {
            return string.Concat(input.DistinctBy(c => c));
        }

        private void ModifyMatrix(Button[,] matrix, int size, int startRow, int startCol, string replacement)
        {
            List<string> newAlphabet = new List<string>(alphabet);
            foreach (char c in replacement)
                newAlphabet.Remove(c.ToString());

            for (int i = startRow, index = 0; i < size; i++)
            {
                for (int j = (i == startRow) ? startCol : 0; j < size; j++)
                {
                    matrix[i, j].Text = newAlphabet[index % newAlphabet.Count];
                    index++;
                }
            }
        }


        private void ReplaceOnMatrix(int size, string text)
        {
            text = DistinctString(text);
            int row = 0, col = 0;
            foreach (char c in text)
            {
                var indexCol = alphabet.IndexOf(c.ToString());
                var indexRow = Convert.ToInt32(c);

                arrayMatrix[row, col].Text = c.ToString();

                while (indexCol > (size - 1))
                    indexCol -= size;

                switch (size)
                {
                    case 5:
                        break;
                    case 6:
                        break;
                }
                col++;
                if (col >= size)
                {
                    col = 0;
                    row++;
                }
            }
            ModifyMatrix(arrayMatrix, size, row, col, text);
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            if (((RadioButton)sender) == rbt5x5)
            {
                panel1.Controls.Clear();
                InitMatrix(5);
                checkString(5);
                check = 5;
                txtKey.Text = "";
                txtResult.Text = "";
                txtKey.KeyPress += Matrix5_KeyPress;
            }
            else if (((RadioButton)sender) == rbt6x6)
            {
                panel1.Controls.Clear();
                InitMatrix(6);
                checkString(6);
                check = 6;
                txtKey.Text = "";
                txtResult.Text = "";
                txtKey.KeyPress += Matrix6_KeyPress;
            }
        }

        private void Matrix5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((new Regex(@"[^jJ\W\d]")).IsMatch(e.KeyChar.ToString()) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Matrix6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((new Regex(@"^\w+|[\d]")).IsMatch(e.KeyChar.ToString()) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void InitMatrix(int size)
        {
            var characters = Enumerable.Range('A', 26)
                .Concat(Enumerable.Range('0', 10))
                .Select(c => (char)c)
                .ToArray();

            alphabet = characters.Select(c => c.ToString()).ToList();

            // Use a single loop with calculated coordinates for button placement
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var charIndex = i * size + j;
                    var charNum = characters[charIndex % characters.Length]; // Handle character wrapping

                    var btn = new Button()
                    {
                        Width = 30,
                        Height = 30,
                        Location = new Point(j * 30, i * 30), // Use simple coordinates
                        Text = charNum.ToString()
                    };

                    arrayMatrix[i, j] = btn;
                    panel1.Controls.Add(btn);
                }
            }
        }

        private void checkString(int size)
        {
            if (txtKey.Text == string.Empty)
            {
                return;
            }
            switch (size)
            {
                case 5:
                    txtKey.Text = Regex.Replace(txtKey.Text, @"[0-9jJ]", "");
                    break;
                case 6:
                    break;
            }
        }

        private int CheckRow(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arrayMatrix[i, j].Text == c.ToString())
                        return i;
                }
            }
            return -1;
        }

        private int CheckCol(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arrayMatrix[i, j].Text == c.ToString())
                        return j;
                }
            }
            return -1;
        }

        private string Encrypt(int size, string pair)
        {
            int r0 = CheckRow(pair[0], size);
            int c0 = CheckCol(pair[0], size);
            int r1 = CheckRow(pair[1], size);
            int c1 = CheckCol(pair[1], size);

            if (c0 == c1)
            {
                if ((r0 + 1) >= size) r0 = -1;
                if ((r1 + 1) >= size) r1 = -1;

                return arrayMatrix[r0 + 1, c0].Text + arrayMatrix[r1 + 1, c0].Text;
            }

            if (r0 == r1)
            {
                if ((c0 + 1) >= size) c0 = -1;
                if ((c1 + 1) >= size) c1 = -1;

                return arrayMatrix[r0, c0 + 1].Text + arrayMatrix[r0, c1 + 1].Text;
            }

            int hC = Math.Abs(c1 - c0);

            if ((c0 + hC) >= size)
            {
                c0 = -c0;
                return arrayMatrix[Math.Abs(r0), Math.Abs(c0 + hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 + hC)].Text;
            }

            if ((c1 + hC) >= size)
            {
                c1 = -c1;
                return arrayMatrix[Math.Abs(r0), Math.Abs(c0 + hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 + hC)].Text;
            }

            if (c0 < c1)
                return arrayMatrix[Math.Abs(r0), Math.Abs(c0 + hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 - hC)].Text;

            return arrayMatrix[Math.Abs(r0), Math.Abs(c0 - hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 + hC)].Text;
        }

        private string Decrypt(int size, string pair)
        {
            int r0 = CheckRow(pair[0], size);
            int c0 = CheckCol(pair[0], size);
            int r1 = CheckRow(pair[1], size);
            int c1 = CheckCol(pair[1], size);

            if (c0 == c1)
            {
                if ((r0 - 1) < 0) r0 = size;
                if ((r1 - 1) < 0) r1 = size;

                return arrayMatrix[r0 - 1, c0].Text + arrayMatrix[r1 - 1, c0].Text;
            }

            if (r0 == r1)
            {
                if ((c0 - 1) < 0) c0 = size;
                if ((c1 - 1) < 0) c1 = size;

                return arrayMatrix[r0, c0 - 1].Text + arrayMatrix[r0, c1 - 1].Text;
            }

            int hC = Math.Abs(c1 - c0);

            if ((c0 + hC) >= size)
            {
                c0 = -c0;
                return arrayMatrix[Math.Abs(r0), Math.Abs(c0 + hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 + hC)].Text;
            }

            if ((c1 + hC) >= size)
            {
                c1 = -c1;
                return arrayMatrix[Math.Abs(r0), Math.Abs(c0 + hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 + hC)].Text;
            }

            if (c0 > c1)
                return arrayMatrix[Math.Abs(r0), Math.Abs(c0 - hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 + hC)].Text;

            return arrayMatrix[Math.Abs(r0), Math.Abs(c0 + hC)].Text + arrayMatrix[Math.Abs(r1), Math.Abs(c1 - hC)].Text;
        }

        private List<string> SplitPairs(string text)
        {
            int index = 0;
            List<string> pairs = new List<string>();

            while (index != text.Length)
            {
                string pair = "";
                for (; index < text.Length; index++)
                {
                    if (pair.Length >= 2) break;
                    pair += text[index];
                }
                pairs.Add(pair);
            }
            return pairs;
        }



        private void btEncrypt_Click(object sender, EventArgs e)
        {
            string text = PreparePlainText(check);
            List<string> pairs = SplitPairs(text);
            txtResult.Text = string.Join("", pairs.Select(pair => Encrypt(check, pair)));
        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            string text = PreparePlainText(check);
            List<string> pairs = SplitPairs(text);
            txtResult.Text = string.Join("", pairs.Select(pair => Decrypt(check, pair)));
        }

        private void btSwap_Click(object sender, EventArgs e)
        {
            string tempText = txtMessage.Text;
            txtMessage.Text = txtResult.Text;
            txtResult.Clear();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKey.Text))
                ReplaceOnMatrix(check, txtKey.Text);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtResult.Clear();
            txtKey.Clear();
            panel1.Controls.Clear();
            InitMatrix(5);
            checkString(5);
            check = 5;
            rbt5x5.Select();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            txtKey.Text = txtKey.Text.Unidecode();
            txtKey.MaxLength = 36;
            txtKey.SelectionStart = txtKey.Text.Length;
            txtKey.Text = txtKey.Text.ToUpper();
        }

        private void btInitialMatrix_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            panel1.Controls.Clear();
            InitMatrix(5);
            checkString(5);
            check = 5;
            rbt5x5.Select();
        }

        private void PlayFairForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }
}

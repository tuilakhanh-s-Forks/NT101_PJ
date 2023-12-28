namespace NT101_PJ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => Application.Exit();
        }

        private void btPlayFair_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayFairForm playFairForm = new PlayFairForm();
            playFairForm.Show();
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            this.Hide();
            RSAForm rsaForm = new RSAForm();
            rsaForm.Show();
        }
    }
}

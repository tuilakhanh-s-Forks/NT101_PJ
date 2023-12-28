namespace NT101_PJ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btPlayFair_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayFairForm playFairForm = new PlayFairForm();
            playFairForm.Show();
        }
    }
}

namespace PtmScreenCapture
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Form loginDialog = new LoginForm();
            loginDialog.ShowDialog();
        }
    }
}
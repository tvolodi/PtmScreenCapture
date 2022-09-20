
using System.Drawing.Imaging;

namespace PtmScreenCapture
{
    public partial class MainForm : Form
    {

        private AdminForm adminForm = new AdminForm();

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

        private void screenshotBtn_Click(object sender, EventArgs e)
        {
            Program.processScreenShot();

            //var screenImage = getScreen();

            //screenImage.Save("screenshot.jpeg", ImageFormat.Jpeg);
        }

        private Bitmap getScreen()
        { 

            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;

            // Create a bitmap of the appropriate size to receive the screenshot.
            Bitmap bmp = new Bitmap(screenWidth, screenHeight);
            
            // Draw the screenshot into our bitmap.
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(screenLeft, screenTop, 0, 0, bmp.Size);
            }

            // Do something with the Bitmap here, like save it to a file:
            return bmp;

            
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            adminForm.Show();            

        }
    }
}
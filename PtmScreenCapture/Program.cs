using PtmScreenCapture.Services;
using System.Drawing.Imaging;
using System.Reflection;

namespace PtmScreenCapture
{
    internal static class Program
    {

        public static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public static int timerInterval = 1 * 60 * 1000; // milliseconds


        // This is the method to run when the timer is raised.
        private static void TimerEventProcessor(Object myObject,
                                                EventArgs myEventArgs)
        {
            timer.Stop();

            processScreenShot();

            timer.Enabled = true;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = timerInterval;
            timer.Start();  

            Application.Run(new MainForm());
        }

        static private Bitmap getScreen()
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

        static public async void processScreenShot()
        {
            string fileName = "last_screenshot.jpeg";

            var screenImage = getScreen();

            screenImage.Save(fileName, ImageFormat.Jpeg);

            var currentPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            string fullFileName = Path.Combine(currentPath, fileName);

            await RestApiService.SendScreenAsync(fullFileName);

        }

        static public void StopTimer()
        {
            if(timer.Enabled) timer.Stop();
        }

        static public void StartTimer()
        {
            if(!timer.Enabled) timer.Start();
        }
    }
}
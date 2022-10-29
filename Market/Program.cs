using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Market
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var LogInForm = new LogIn.LogIn();
            if (LogInForm.ShowDialog() != DialogResult.OK)
                Process.GetCurrentProcess().Kill();
            Application.Run(new Main.Main());
        }
    }
}

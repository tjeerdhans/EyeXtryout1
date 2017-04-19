using System;
using System.Windows.Forms;
using EyeXFramework.Forms;

namespace EyeXtryout1
{
    static class Program
    {
        private static readonly FormsEyeXHost _eyeXHost = new FormsEyeXHost();


        /// <summary>
        /// Gets the singleton EyeX host instance.
        /// </summary>
        public static FormsEyeXHost EyeXHost
        {
            get { return _eyeXHost; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _eyeXHost.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            _eyeXHost.Dispose();
        }
    }
}

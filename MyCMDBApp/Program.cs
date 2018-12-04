using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCMDBApp
{
    static class Program
    {
        //public static bool OpenStartupFormOnClose { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //OpenStartupFormOnClose = false;

            Application.Run(new SignInForm());

            //if (OpenStartupFormOnClose)
            //{
            //    Application.Run(new StartupForm());
            //}
        }
    }
}

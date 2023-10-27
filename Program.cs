using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDesignSamples
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Form1());

            // View login templates
            LoginForms.FormLoginIndex FormLoginIndexObj = new LoginForms.FormLoginIndex();
            FormLoginIndexObj.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SisCad.Forms
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
            frmLogin form = new frmLogin();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }
            //Application.Run(new frmPrincipal());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSYS
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
            //Application.Run(new frmMainPage);
            //Application.Run(new frmLogin());

            //Application.Run(new frmCatalogueDVD());
            Application.Run(new frmRemove());
            //Application.Run(new frmListOverdue());
            
            //Application.Run(new frmAddMem());
            //Application.Run(new frmUpdateMem());

            //Application.Run(new frmRent());
            //Application.Run(new frmReturn());
            //Application.Run(new frmFines());

        }
    }
}

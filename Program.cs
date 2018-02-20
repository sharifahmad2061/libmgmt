using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libmgmt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //static Form main_form = new mainForm();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}

using bharatplantdesktop.UI;
using bharatplantdesktop.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bharatplantdesktop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of your TabSwitchMessageFilter and add it as a message filter
            TabSwitchMessageFilter messageFilter = new TabSwitchMessageFilter();
            Application.AddMessageFilter(messageFilter);

            Application.Run(new frmLogin());
        }
    }
}

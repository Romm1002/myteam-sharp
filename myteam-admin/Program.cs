﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using myteam_admin.Fenetres;

namespace myteam_admin
{
    static class Program
    {
        [DllImport("Shcore.dll")]
        static extern int SetProcessDpiAwareness(int PROCESS_DPI_AWARENESS);
        // According to https://msdn.Microsoft.com/en-us/library/windows/desktop/dn280512(v=vs.85).aspx
        private enum DpiAwareness
        {
            None = 0,
            SystemAware = 1,
            PerMonitorAware = 2
        }
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SetProcessDpiAwareness((int)DpiAwareness.PerMonitorAware);

            Application.Run(new Accueil());
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BNSBan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Config.ReadConfig();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BNSBlacklist());
        }
    }

}

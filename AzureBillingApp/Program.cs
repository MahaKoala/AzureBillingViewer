﻿using System;
using System.Windows.Forms;
using App.Common.Enums;
using AzureBillingApp.Forms;

namespace AzureBillingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitAppSettings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWnd());
        }

        private static void InitAppSettings()
        {
            AppSettings.ApiVersion = ResourceFileVersion.Version2;
        }
    }
}

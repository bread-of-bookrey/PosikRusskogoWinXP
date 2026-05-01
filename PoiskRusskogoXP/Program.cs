using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PoiskRusskogoXP
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

            // Init
            MainForm mainForm = new MainForm();

            Controller.LogManager logManager = new Controller.LogManager(mainForm.LogWindow);

            Controller.FileSearcher fileSearcher = new Controller.FileSearcher(logManager);
            mainForm.СhooseFileButton.Click += fileSearcher.GetChosenFileText;


            Application.Run(mainForm);
        }
    }
}

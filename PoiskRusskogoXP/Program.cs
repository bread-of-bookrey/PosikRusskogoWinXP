using PoiskRusskogoXP.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PoiskRusskogoXP
{
    static class Program
    {
        // Adidng console
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Init
            MainForm mainForm = new MainForm();

            Model.RusCharAnalizer rusCharAnalizer = new Model.RusCharAnalizer();

            Controller.LogManager logManager = new Controller.LogManager(mainForm.LogWindow);
            Controller.PathShowerManager pathShowerManager = new Controller.PathShowerManager(mainForm.PathShower);

            Controller.FileSearcher fileSearcher = new Controller.FileSearcher(logManager, pathShowerManager, rusCharAnalizer);
            mainForm.СhooseFileButton.Click += fileSearcher.GetChosenFileText;


            Application.Run(mainForm);
        }
        public static void OpenConsole()
        {
            AllocConsole();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing;
using PoiskRusskogoXP.Model;

namespace PoiskRusskogoXP.Controller
{
    class FileSearcher
    {
        public string ChosenFilePath;
        public string[] ChosenFileText;

        private LogManager logManager;
        private PathShowerManager pathShowerManager;
        private RusCharAnalizer rusCharAnal;

        public FileSearcher(LogManager logManager, PathShowerManager pathShowerManager, RusCharAnalizer rusCharAnal)
        {
            this.logManager = logManager;
            this.pathShowerManager = pathShowerManager;
            this.rusCharAnal = rusCharAnal;
        }


        public void GetChosenFileText(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы (*.txt, *.dmi, *.res)|*.txt;*.dmi;*.res";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                ChosenFileText = File.ReadAllLines(dlg.FileName);
                ChosenFilePath = dlg.FileName;

                pathShowerManager.UpdatePath(ChosenFilePath);
                logManager.WriteMessage($"Анализ файла {ChosenFilePath}");

                rusCharAnal.UpdatePath(ChosenFilePath);
                rusCharAnal.Analize(ChosenFileText);            
            }
        }
    }
}

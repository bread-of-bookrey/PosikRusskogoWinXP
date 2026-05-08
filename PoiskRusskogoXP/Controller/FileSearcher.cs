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
        public Encoding ChosenFileEncoding;

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
                // Определяем кодировку файла
                Encoding encoding = EncodingDetector.Detect(dlg.FileName);

                // Читаем все строки с определённой кодировкой
                ChosenFileText = File.ReadAllLines(dlg.FileName, encoding);
                ChosenFilePath = dlg.FileName;

                pathShowerManager.UpdatePath(ChosenFilePath);
                logManager.WriteMessage($"Анализ файла {ChosenFilePath}");

                rusCharAnal.UpdatePath(ChosenFilePath);
                rusCharAnal.Analize(ChosenFileText);
            }
        }
    }
}

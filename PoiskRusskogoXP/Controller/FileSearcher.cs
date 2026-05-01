using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing;

namespace PoiskRusskogoXP.Controller
{
    class FileSearcher
    {
        public string ChosenFilePath;
        public string ChosenFileText;

        private LogManager logManager;
        private PathShowerManager pathShowerManager;

        public FileSearcher(LogManager logManager, PathShowerManager pathShowerManager)
        {
            this.logManager = logManager;
            this.pathShowerManager = pathShowerManager;
        }


        public void GetChosenFileText(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы (*.txt, *.dmi, *.res)|*.txt;*.dmi;*.res";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Encoding enc = DetectEncoding(dlg.FileName);
                ChosenFileText = File.ReadAllText(dlg.FileName, enc);
                ChosenFilePath = dlg.FileName;

                pathShowerManager.UpdatePath(ChosenFilePath);
                logManager.WriteMessage($"Анализ файла {ChosenFilePath}");
            }
        }

        private static Encoding DetectEncoding(string filePath)
        {
            byte[] raw = File.ReadAllBytes(filePath);
            // Проверка BOM
            if (raw.Length >= 2 && raw[0] == 0xFF && raw[1] == 0xFE)
                return Encoding.Unicode;
            if (raw.Length >= 2 && raw[0] == 0xFE && raw[1] == 0xFF)
                return Encoding.BigEndianUnicode;
            if (raw.Length >= 3 && raw[0] == 0xEF && raw[1] == 0xBB && raw[2] == 0xBF)
                return Encoding.UTF8;
            // Попытка прочитать как UTF-8 без BOM и проверить на символ замены
            string utf8String = Encoding.UTF8.GetString(raw);
            if (!utf8String.Contains("\uFFFD"))
                return Encoding.UTF8;
            // Иначе считаем, что это ANSI (Windows-1251)
            return Encoding.GetEncoding(1251);
        }
    }
}

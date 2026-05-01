using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.CodeDom;
using PoiskRusskogoXP.Controller;
using System.Windows.Forms;

namespace PoiskRusskogoXP.Model
{
    class RusCharAnalizer
    {
        public List<string> PurifiedText;
        public string PurifiedFileName;
        public LogManager LogManag;
        public Button AutoCorrectButton;
        private bool isAnalCompleted;

        public RusCharAnalizer(LogManager logManager, Button autoCorrectBtn)
        {
            PurifiedText = new List<string>();
            this.LogManag = logManager;
            AutoCorrectButton = autoCorrectBtn;

            isAnalCompleted = false;

            this.AutoCorrectButton.Click += new EventHandler(this.SavePurifiedText);
        }

        public void Analize(string[] text)
        {
            int cnt = 0;
            Program.OpenConsole();

            for (int i = 0; i < text.Length; i++)
            {
                string textLine = String.Empty;

                Console.Write($"{i + 1}.    ");
                foreach (char c in text[i])
                {
                    int code = (int)c;

                    if ((code >= 0x0400 && code <= 0x04FF) || (code >= 0x0500 && code <= 0x052F))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(c);
                        Console.ForegroundColor = ConsoleColor.White;
                        cnt++;
                    }
                    else
                    {
                        Console.Write(c);
                        textLine += c;
                        
                    }
                }
                PurifiedText.Add(textLine);
                Console.WriteLine();
            }

            isAnalCompleted = true;
            LogManag.WriteMessage("Анализ завершён.");
            LogManag.WriteMessage($"Русских символов найдено:    {cnt}");
        }

        public void UpdatePath(string fileName)
        {
            string sourceDirectory = Path.GetDirectoryName(fileName);
            string sourceExtension = Path.GetExtension(fileName);
            string sourceName = Path.GetFileNameWithoutExtension(fileName);
            PurifiedFileName = Path.Combine(sourceDirectory, sourceName + "_NoRussian" + sourceExtension);

        }

        public void SavePurifiedText(object sender, EventArgs e)
        {
            if (isAnalCompleted)
            {
                File.WriteAllLines(PurifiedFileName, PurifiedText.ToArray());
                LogManag.WriteMessage("Отредактированный файл сохранён в папке с оригиналом.");
            }
            else
            {
                LogManag.WriteMessage("Сначала выберите файл для коррекции!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PoiskRusskogoXP.Model
{
    public static class EncodingDetector
    {
        public static Encoding Detect(string filePath)
        {
            // Читаем первые 4 байта для проверки BOM
            byte[] bom = new byte[4];
            int bytesRead;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                bytesRead = fs.Read(bom, 0, bom.Length);
            }

            // Проверяем известные BOM
            if (bytesRead >= 3 && bom[0] == 0xEF && bom[1] == 0xBB && bom[2] == 0xBF)
                return Encoding.UTF8;
            if (bytesRead >= 2 && bom[0] == 0xFF && bom[1] == 0xFE)
                return Encoding.Unicode; // UTF-16 LE
            if (bytesRead >= 2 && bom[0] == 0xFE && bom[1] == 0xFF)
                return Encoding.BigEndianUnicode;
            if (bytesRead >= 4 && bom[0] == 0x00 && bom[1] == 0x00 && bom[2] == 0xFE && bom[3] == 0xFF)
                return Encoding.UTF32;

            // BOM отсутствует – пробуем прочитать как UTF-8
            string text = File.ReadAllText(filePath, Encoding.UTF8);
            if (text.IndexOf('\uFFFD') >= 0)
            {
                // Содержит знаки замены => невалидный UTF-8
                return Encoding.Default;   // системная ANSI (например, windows-1251 на русской XP)
            }
            else
            {
                return Encoding.UTF8;      // валидный UTF-8 без BOM
            }
        }
    }
}

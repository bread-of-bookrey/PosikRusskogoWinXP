using System;
using System.IO;
using System.Text;

namespace PoiskRusskogoXP.Controller
{
    public static class EncodingDetector
    {
        /// <summary>
        /// Определяет кодировку файла. Сначала проверяет BOM, затем эвристику для ANSI.
        /// </summary>
        public static Encoding DetectFileEncoding(string filePath)
        {
            // 1. Пытаемся определить по BOM (используем улучшенную версию из StackOverflow)
            Encoding bomEnc = BomInfo(filePath);
            if (bomEnc != null)
                return bomEnc;

            // 2. Загружаем весь файл для эвристики
            byte[] raw = File.ReadAllBytes(filePath);

            // 3. Пробуем ANSI (Windows-1251) – наиболее вероятная для русских текстов
            Encoding ansi = Encoding.GetEncoding(1251);
            string ansiText = ansi.GetString(raw);
            if (ContainsRussian(ansiText))
                return ansi;

            // 4. Если русских нет, пробуем UTF-8 без BOM (валидность не проверяем, т.к. файлы без BOM могут быть любыми)
            string utf8Text = Encoding.UTF8.GetString(raw);
            // Если в UTF-8 нет символа замены – это вероятный UTF-8 или ASCII
            if (utf8Text.IndexOf("\uFFFD") == -1)
                return Encoding.UTF8;

            // 5. По умолчанию возвращаем системную кодировку (на русской Windows это 1251)
            return GetSystemEncoding();
        }

        /// <summary>Определяет кодировку по BOM (сигнатуре в начале файла).</summary>
        private static Encoding BomInfo(string srcFile)
        {
            byte[] b = new byte[5];
            using (FileStream file = new FileStream(srcFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                int numRead = file.Read(b, 0, 5);
                if (numRead < 5)
                    Array.Resize(ref b, numRead);
                file.Close();
            }

            // BOM для UTF-32 (big-endian)
            if (b.Length >= 4 && b[0] == 0x00 && b[1] == 0x00 && b[2] == 0xFE && b[3] == 0xFF)
                return Encoding.GetEncoding(12001); // UTF-32BE
            // BOM для UTF-32 (little-endian)
            if (b.Length >= 4 && b[0] == 0xFF && b[1] == 0xFE && b[2] == 0x00 && b[3] == 0x00)
                return Encoding.UTF32; // UTF-32LE
            // BOM для UTF-7 (редко)
            if (b.Length >= 4 && b[0] == 0x2B && b[1] == 0x2F && b[2] == 0x76 && (b[3] == 0x38 || b[3] == 0x39 || b[3] == 0x2B || b[3] == 0x2F))
                return Encoding.UTF7;
            // BOM для UTF-8
            if (b.Length >= 3 && b[0] == 0xEF && b[1] == 0xBB && b[2] == 0xBF)
                return Encoding.UTF8;
            // BOM для UTF-16 (big-endian)
            if (b.Length >= 2 && b[0] == 0xFE && b[1] == 0xFF)
                return Encoding.BigEndianUnicode;
            // BOM для UTF-16 (little-endian)
            if (b.Length >= 2 && b[0] == 0xFF && b[1] == 0xFE)
                return Encoding.Unicode;

            return null; // BOM не найден
        }

        private static bool ContainsRussian(string text)
        {
            foreach (char c in text)
                if (c >= 'А' && c <= 'я' || c == 'Ё' || c == 'ё')
                    return true;
            return false;
        }

        private static Encoding GetSystemEncoding()
        {
            int ansiCodePage = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ANSICodePage;
            try
            {
                return Encoding.GetEncoding(ansiCodePage);
            }
            catch
            {
                return Encoding.Default; // запасной вариант
            }
        }
    }
}
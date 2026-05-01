using System;
using System.Collections.Generic;
using System.Text;

namespace PoiskRusskogoXP.Model
{
    class RusCharAnalizer
    {
        public RusCharAnalizer()
        { }

        public void Analize(string[] text)
        {
            Program.OpenConsole();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write($"{i + 1}.    ");
                foreach (char c in text[i])
                {
                    int code = (int)c;

                    if ((code >= 0x0400 && code <= 0x04FF) || (code >= 0x0500 && code <= 0x052F))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(c);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(c);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

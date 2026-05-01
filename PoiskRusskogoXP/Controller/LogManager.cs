using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;


namespace PoiskRusskogoXP.Controller
{
    class LogManager
    {
        private TextBox logWindow;

        public LogManager(TextBox logWindow)
        {
            this.logWindow = logWindow;
            WriteMessage("Ожидание...");
      
        }

        public void WriteMessage(string message)
        {
            logWindow.AppendText(message + Environment.NewLine);
            logWindow.ScrollToCaret();
        }

    }
}

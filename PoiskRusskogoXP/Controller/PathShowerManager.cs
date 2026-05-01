using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PoiskRusskogoXP.Controller
{
    class PathShowerManager
    {
        public TextBox PathShower;

        public PathShowerManager(TextBox pthShwr)
        {
            this.PathShower = pthShwr;
        }

        public void UpdatePath(string path)
        {
            PathShower.Text = path;
        }
    }
}

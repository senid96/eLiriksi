using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liriksi.WinUI.Helper
{
    public static class HelperMethods
    {
        public static void CloseAllForms()
        {
            for (int x = 0; x < Application.OpenForms.Count; x++)
            {
                if (Application.OpenForms[x] != Application.OpenForms["frmIndex"])
                    Application.OpenForms[x].Close();
            }
        }
    }
}

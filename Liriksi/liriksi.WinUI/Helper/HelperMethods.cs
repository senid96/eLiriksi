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
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            
            foreach (Form f in openForms)
            {
                if(!f.Name.Equals("frmIndex"))
                    f.Visible = false;
            }

            
        }

        public static void OpenForm(string frmName, string frmNamespace)
        {
            //genericko otvaranje formi jednom metodom
            var form = Activator.CreateInstance(Type.GetType(frmNamespace + "."+ frmName)) as Form;
            form.Show();
        }

        public static void CloseForm(string frmName)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name.Equals(frmName))
                    f.Visible = false;
            }
        }
    }
}

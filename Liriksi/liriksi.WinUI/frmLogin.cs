using liriksi.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liriksi.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _userService = new APIService("user");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                APIService._username = txtboxUsername.Text;
                APIService._password = txtboxPassword.Text;

                await _userService.Get<dynamic>(null, null);

                frmIndex frm = new frmIndex();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK);
            }
           
        }
    }
}

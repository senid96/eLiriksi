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
                APIService._currentUser = await _userService.Get<Model.User>(null, "GetMyProfile");
                if(APIService._currentUser != null)
                {
                    frmIndex frm = new frmIndex();
                    frm.Show();
                }
                else //todo srediti ovo malo.. procackat jos
                {
                    MessageBox.Show("Username or password are not valid", "Authentication", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK);
            }
           
        }
    }
}

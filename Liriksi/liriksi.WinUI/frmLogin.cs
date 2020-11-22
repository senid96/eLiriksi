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
            if (this.ValidateChildren())
            {
                try
                {
                    APIService._username = txtboxUsername.Text;
                    APIService._password = txtboxPassword.Text;

                    //za testiranje todo, vratiti kasnije
                    //APIService._username = "testiranje";
                    //APIService._password = "testiranje";

                    APIService._currentUser = await _userService.Get<Model.User>(null, "GetMyProfile");
                    if (APIService._currentUser != null)
                    {
                        frmIndex frm = new frmIndex();
                        frm.IsMdiContainer = true;
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or password incorect!", "Authentication", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Authentication error", MessageBoxButtons.OK);
                }
            }

        }

        private void txtboxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxUsername.Text))
            {
                errorProvider.SetError(txtboxUsername, "Required field!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtboxUsername, null);
            }
        }

        private void txtboxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxPassword.Text))
            {
                errorProvider.SetError(txtboxPassword, "Required field!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtboxPassword, null);
            }
        }
    }
}

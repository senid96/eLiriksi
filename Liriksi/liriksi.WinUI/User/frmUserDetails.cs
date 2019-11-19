using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using liriksi.Model.Requests;

namespace liriksi.WinUI.User
{
    public partial class frmUserDetails : Form
    {
        private readonly APIService _userService = new APIService("user");
        
        public frmUserDetails()
        {
            InitializeComponent();
        }

        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            UserInsertRequest user = new UserInsertRequest();
            user.Name = txtboxName.Text;
            user.Surname = txtboxSurname.Text;
            user.Email = txtboxEmail.Text;
            user.PhoneNumber = txtBoxPhone.Text;
            user.Username = txtboxUsername.Text;
            user.Password = txtboxPassword.Text;
            user.PasswordConfirmation = txtboxPasswordConf.Text;

            
          //_userService.. // TODO 
        }

        private void FrmUserDetails_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

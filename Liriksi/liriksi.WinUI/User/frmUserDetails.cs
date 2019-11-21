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
        private int? _userId;
        
        public frmUserDetails(int? userId = null)
        {
            _userId = userId;
            InitializeComponent();
        }

        private async void BtnSaveUser_Click(object sender, EventArgs e)
        {
            UserInsertRequest user = new UserInsertRequest();
            user.Name = txtboxName.Text;
            user.Surname = txtboxSurname.Text;
            user.Email = txtboxEmail.Text;
            user.PhoneNumber = txtBoxPhone.Text;
            user.Username = txtboxUsername.Text;
            user.Password = txtboxPassword.Text;
            user.PasswordConfirmation = txtboxPasswordConf.Text;

            if (_userId.HasValue)
            {
                await _userService.Update<UserInsertRequest>(_userId.Value, user);
            }
            else
            {
                //radimo insert
                await _userService.Insert<UserInsertRequest>(user);

            }
        }

        private async void FrmUserDetails_Load(object sender, EventArgs e)
        {
            if (_userId.HasValue)
            {
                var user = await _userService.GetById<UserGetRequest>(_userId);
                txtboxName.Text = user.Name;
                txtboxSurname.Text = user.Surname;
                txtboxEmail.Text = user.Email;
                txtBoxPhone.Text = user.PhoneNumber;
                txtboxUsername.Text = user.Username;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

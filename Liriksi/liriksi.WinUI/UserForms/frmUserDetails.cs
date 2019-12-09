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
            UserInsertRequest user = new UserInsertRequest
            {
                Name = txtboxName.Text,
                Surname = txtboxSurname.Text,
                Email = txtboxEmail.Text,
                PhoneNumber = txtBoxPhone.Text,
                Username = txtboxUsername.Text,
                Password = txtboxPassword.Text,
                PasswordConfirmation = txtboxPasswordConf.Text,
                UserTypeId = 2 //todo
            };
            if (_userId.HasValue)
            {
                _ = await _userService.Update<UserGetRequest>(_userId.Value, user); //update
                this.Close(); //close current detail form

               
                
                //find open form and close it
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].Name == "frmUser")
                    {
                        Application.OpenForms[i].Refresh();
                        Application.DoEvents();
                    }
                }

                ////refresh form
                //frmUser frm = new frmUser();
                //frm.dgvUser.DataSource = await _userService.Get<List<UserGetRequest>>(null);
                //frm.Show();
            }
            else
            {               
                //radimo insert
               _ = await _userService.Insert<UserGetRequest>(user);
                this.Close();
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

        private void TxtboxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

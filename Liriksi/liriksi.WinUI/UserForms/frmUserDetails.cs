using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (this.ValidateChildren()) //if all controls are validated
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
                if (_userId.HasValue) //if user exist (update), if not (insert)
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

        private void TxtboxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxName.Text))
            {
                errorProvider1.SetError(txtboxName, "Required field");
                e.Cancel = true; //cancel further form execution
            }
            else
            {
                errorProvider1.SetError(txtboxName, null); //to clear error
            }
        }

        private void TxtboxSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxSurname.Text))
            {
                errorProvider1.SetError(txtboxSurname, "Required field");
            }
            else
            {
                errorProvider1.SetError(txtboxSurname, null);
            }
        }

        private void TxtboxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxEmail.Text))
            {
                errorProvider1.SetError(txtboxEmail, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtboxEmail, null);

                //email format validation
                string email = txtboxEmail.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    errorProvider1.SetError(txtboxEmail, null);
                }
                else
                {
                    errorProvider1.SetError(txtboxEmail, "Invalid email format");
                    e.Cancel = true;
                }
            }
        }

        private void TxtboxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void TxtBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!txtBoxPhone.MaskCompleted)
            {
                errorProvider1.SetError(txtBoxPhone, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtBoxPhone, null);
            }

        }

        private void TxtboxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtboxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxUsername.Text))
            {
                errorProvider1.SetError(txtboxUsername, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtboxUsername, null);
            }
        }

        private void TxtboxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxPassword.Text))
            {
                errorProvider1.SetError(txtboxPassword, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtboxPassword, null);
            }
        }

        private void TxtboxPasswordConf_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxPasswordConf.Text))
            {
                errorProvider1.SetError(txtboxPasswordConf, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtboxPasswordConf, null);

                //check if paswords match
                //if (!txtboxPassword.Text.Equals(txtboxPasswordConf.Text))
                //{
                //    errorProvider1.SetError(txtboxPasswordConf, "Password doesn't match");
                //    e.Cancel = true;
                //}
                //else
                //{
                //    errorProvider1.SetError(txtboxPasswordConf, null);
                //}
            }
        }

        private void TxtboxPasswordConf_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnResetInputs_Click(object sender, EventArgs e)
        {

        }
    }
}

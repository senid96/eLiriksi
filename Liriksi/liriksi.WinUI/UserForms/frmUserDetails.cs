using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using liriksi.Model.Requests;
using liriksi.WinUI.Helper;

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
                    UserTypeId = 2, //todo
                    CityId = 4 //todo
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
                    _ = await _userService.Insert<UserGetRequest>(user, "InsertUser");
                    this.Close();
                }
            }
        }

        private async void FrmUserDetails_Load(object sender, EventArgs e)
        {
            if (_userId.HasValue)
            {
                var user = await _userService.GetById<UserGetRequest>(_userId, null);
                txtboxName.ReadOnly = true;
                txtboxName.Text = user.Name;

                txtboxSurname.Text = user.Surname;
                txtboxSurname.ReadOnly = true;

                txtboxEmail.Text = user.Email;
                txtboxEmail.ReadOnly = true;

                txtBoxPhone.Text = user.PhoneNumber;
                txtBoxPhone.ReadOnly = true;

                txtboxUsername.Text = user.Username;
                txtboxUsername.ReadOnly = true;

                txtboxCity.Text = user.City.Name;
                txtboxCity.ReadOnly = true;

                txtboxUserType.ReadOnly = true;
                txtboxUserType.Text = user.UserType.Type;

                //prepare image to display from db
                if (user.Image.Length > 0)
                {
                    byte[] imgData = user.Image;
                    MemoryStream stream = new MemoryStream(imgData);
                    picboxUser.Image = ImageHelperMethods.ResizeImage(Image.FromStream(stream), 120, 120);
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtboxName_TextChanged(object sender, EventArgs e)
        {

        }


        //private void TxtboxEmail_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtboxEmail.Text))
        //    {
        //        errorProvider1.SetError(txtboxEmail, "Required field");
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtboxEmail, null);
        //regex email
        //        //email format validation
        //        string email = txtboxEmail.Text;
        //        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        //        Match match = regex.Match(email);
        //        if (match.Success)
        //        {
        //            errorProvider1.SetError(txtboxEmail, null);
        //        }
        //        else
        //        {
        //            errorProvider1.SetError(txtboxEmail, "Invalid email format");
        //            e.Cancel = true;
        //        }
        //    }
        //}

        private void TxtboxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void TxtboxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtboxPasswordConf_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnResetInputs_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //added to enable to close form (error provider disnable to close form)
            e.Cancel = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

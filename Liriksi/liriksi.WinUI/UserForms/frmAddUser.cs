using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WinUI.Helper;
using liriksi.WinUI.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liriksi.WinUI.UserForms
{
    public partial class frmAddUser : Form
    {
        APIService _userService = new APIService("user");
        APIService _locationService = new APIService("location");
        public frmAddUser()
        {
            InitializeComponent();
        }

        //upload slike
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                //ako si odabrao sliku prikazi, ako si zatvorio dialog i nisi odabrao - nemoj prikazivati
                //padne ako se ovako ne stavi
                //prepare for display
                if (!openFileDialog.FileName.Equals(""))
                {
                    Bitmap img = new Bitmap(openFileDialog.FileName);
                    picboxUser.Image = ImageHelperMethods.ResizeImage(img, 120, 120);
                }
              
            }
        }

        private async void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (picboxUser.Image == null)
                {
                    errorProvider.SetError(picboxUser, "Image is required!");
                    return;
                }
                else
                {
                    errorProvider.SetError(picboxUser, null);
                }
              
                 
                //prepare image for database
                byte[] ImageData = ImageHelperMethods.PrepareImgForDB(picboxUser.Image);

                UserInsertRequest obj = new UserInsertRequest()
                {
                    Name = txtboxName.Text,
                    Surname = txtboxSurname.Text,
                    Username = txtboxUsername.Text,
                    Email = txtboxEmail.Text,
                    PhoneNumber = txtBoxPhone.Text,
                    UserTypeId = Convert.ToInt32(cmbUserType.SelectedValue),
                    CityId = Convert.ToInt32(cmbCity.SelectedValue),
                    Password = txtboxPassword.Text,
                    PasswordConfirmation = txtboxConfirmPassword.Text,
                    Image = ImageData,
                    Status = true //active by default
                };

                await _userService.Insert<UserInsertRequest>(obj, "InsertUser");
                this.Close();
            }
        }

        private async void frmAddUser_Load(object sender, EventArgs e)
        {
            cmbUserType.DataSource = await _userService.Get<List<UserType>>(null, "GetUserTypes");
            cmbUserType.DisplayMember = "Type";
            cmbUserType.ValueMember = "Id";

            cmbCountry.DataSource = await _locationService.Get<List<Country>>(null, "GetCountries");
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "Id";

            cmbCity.DataSource = await _locationService.GetById<List<City>>(cmbCountry.SelectedValue, "GetCitiesByCountryId");
            cmbCity.DisplayMember = "Name";
            cmbCity.ValueMember = "Id";

        }

        private async void cmbCountry_DropDownClosed(object sender, EventArgs e)
        {
            cmbCity.DataSource =  await _locationService.GetById<List<City>>(cmbCountry.SelectedValue, "GetCitiesByCountryId");
            cmbCity.DisplayMember = "Name";
            cmbCity.ValueMember = "Id";
        }

        private void frmAddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmUser frm = new frmUser();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.Show();
        }

        private void txtboxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxName.Text))
            {
                errorProvider.SetError(txtboxName, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtboxName, null);
            }
        }

        private void txtboxSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxSurname.Text))
            {
                errorProvider.SetError(txtboxSurname, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtboxSurname, null);

            }
        }

        private void txtBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPhone.Text))
            {
                errorProvider.SetError(txtBoxPhone, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBoxPhone, null);
            }
        }

        private void txtboxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxUsername.Text))
            {
                errorProvider.SetError(txtboxUsername, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtboxUsername, null);
            }
        }

        private void txtboxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxEmail.Text))
            {
                errorProvider.SetError(txtboxEmail, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtboxEmail, null);
            }
        }

        private void txtboxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxPassword.Text))
            {
                errorProvider.SetError(txtboxPassword, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtboxPassword, null);
            }
        }

        private void txtboxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxConfirmPassword.Text))
            {
                errorProvider.SetError(txtboxConfirmPassword, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtboxConfirmPassword, null);
            }
        }

        private void frmAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}

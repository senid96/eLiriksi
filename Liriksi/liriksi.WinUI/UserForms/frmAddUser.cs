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
                Bitmap img = new Bitmap(openFileDialog.FileName);
                picboxUser.Image = HelperMethods.ResizeImage(img,  120, 120);
                txtboxImgPath.Text = filePath;
            }
        }

        private async void btnSaveUser_Click(object sender, EventArgs e)
        {
            //prepare image for database
            string FileName = txtboxImgPath.Text;
            byte[] ImageData;
            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            //end prepare image for database

            UserInsertRequest obj = new UserInsertRequest()
            {
                Name = txtboxName.Text,
                Surname = txtboxSurname.Text,
                Username = txtboxSurname.Text,
                Email = txtboxEmail.Text,
                PhoneNumber = txtBoxPhone.Text,
                UserTypeId = Convert.ToInt32(cmbUserType.SelectedValue),
                CityId = Convert.ToInt32(cmbCity.SelectedValue),
                Password = txtboxPassword.Text,
                PasswordConfirmation = txtboxConfirmPassword.Text,
                Image = ImageData,
                Status = true //active by default
            };

            try
            {
                await _userService.Insert<UserInsertRequest>(obj);
                this.Close();
            }
            catch (Exception)
            {
                throw;
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
    }
}

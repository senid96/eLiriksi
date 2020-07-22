using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;
using liriksi.Model.Requests;

namespace liriksi.WinUI.User
{
    public partial class frmUser : Form
    {

        private readonly APIService _userService = new APIService("user");
        public frmUser()
        {
            InitializeComponent();
          
            //dgvUser.DataSource = _apiService.Get<dynamic>();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void FrmUser_Load(object sender, EventArgs e)
        {
            dgvUser.AutoGenerateColumns = false;
            dgvUser.DataSource = await _userService.Get<List<UserGetRequest>>(null,null);
        }

        private async void BtnShow_Click(object sender, EventArgs e)
        {
            var search = new UserSearchRequest()
            {
                Name = txtboxName.Text,
                Surname = txtboxSurname.Text            
            };

            var result = await _userService.Get<List<UserGetRequest>>(search, null);

            dgvUser.DataSource = result;
        }

        private void TxtSearchParameter_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSearchParam_Click(object sender, EventArgs e)
        {

        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            txtboxName.Text = "";
            txtboxSurname.Text = "";
        }

        private void DgvUser_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvUser.SelectedRows[0].Cells[0].Value;
            frmUserDetails frm = new frmUserDetails(int.Parse(id.ToString()));
            frm.Show();
        }

        private void DgvUser_AllowUserToOrderColumnsChanged(object sender, EventArgs e)
        {

        }
    }
}

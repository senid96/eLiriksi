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
namespace liriksi.WinUI.User
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
            var result = "https://localhost:44313/api/User".GetJsonAsync<dynamic>().Result;
            dgvUser.DataSource = result;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUser_Load(object sender, EventArgs e)
        {

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            var result = "https://localhost:44313/api/User".GetJsonAsync<dynamic>().Result;
            dgvUser.DataSource = result;
        }
    }
}

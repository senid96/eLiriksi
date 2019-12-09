using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using liriksi.Model;
using liriksi.Model.Requests;

namespace liriksi.WinUI.SongForms
{
    public partial class frmSong : Form
    {
        private readonly APIService _apiService = new APIService("song");
        public frmSong()
        {
            InitializeComponent();
        }

        private async void BtnSongSearch_Click(object sender, EventArgs e)
        {          
            var data = await _apiService.Get<List<SongGetRequest>>(txtboxTitle.Text);
            dgvSong.DataSource = data;           
        }

        private void DgvSong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvSong_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvSong.SelectedRows[0].Cells[0].Value.ToString();
            frmSongDetails frm = new frmSongDetails(int.Parse(id));
            frm.Show();
        }
    }
}

using liriksi.Model;
using liriksi.Model.Requests.album;
using liriksi.WinUI.AlbumForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liriksi.WinUI.SongForms.AlbumForms
{
    public partial class frmAlbum : Form
    {
        APIService _albumService = new APIService("album");
        public frmAlbum()
        {
            InitializeComponent();
            dgvAlbum.AutoGenerateColumns = false;
        }

        private async void frmAlbum_Load(object sender, EventArgs e)
        {
            dgvAlbum.DataSource = await _albumService.Get<List<Album>>(null, null);
        }

        private async void btnSearchAlbum_Click(object sender, EventArgs e)
        {
                AlbumSearchRequest obj = new AlbumSearchRequest { Name = txtboxAlbumName.Text };
                dgvAlbum.DataSource = await _albumService.Get<List<Album>>(obj, null);
        }

        private void dgvAlbum_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvAlbum.SelectedRows[0].Cells[0].Value.ToString();
            frmAlbumDetails frm = new frmAlbumDetails(int.Parse(id));
            frm.Show();
        }
    }
}

using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.Model.Requests.album;
using liriksi.WinUI.AlbumForms;
using liriksi.WinUI.Helper;
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

        private void dgvAlbum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnUpdateAlbum_Click(object sender, EventArgs e)
        {
            int albumId = Convert.ToInt32(dgvAlbum.SelectedRows[0].Cells[0].Value.ToString());
            HelperMethods.CloseAllForms();
            frmUpdateAlbum frm = new frmUpdateAlbum(albumId);
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}

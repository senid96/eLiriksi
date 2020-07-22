using liriksi.Model;
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
        }

        private async void frmAlbum_Load(object sender, EventArgs e)
        {
            dgvAlbum.AutoGenerateColumns = false;
            dgvAlbum.DataSource = await _albumService.Get<List<Album>>(null, null);
        }

        private void dgvAlbum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

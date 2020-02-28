using liriksi.Model.Requests;
using liriksi.WinUI.UtilForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liriksi.WinUI.SongForms
{
    public partial class frmAddSong : Form
    {
        APIService _SongService = new APIService("song");

        public frmAddSong()
        {
            InitializeComponent();
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            frmAddAlbum frm = new frmAddAlbum();
            frm.Show();
            //frm.MdiParent = this; //todo
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {
            //Provjeriti todo
            SongInsertRequest req = new SongInsertRequest();
            req.Title = txtName.Text;
            req.Text = txtLyrics.Text;
            req.AlbumId = cmbAlbum.SelectedIndex;
            req.PerformerId = cmbPerformer.SelectedIndex;

            await _SongService.Insert<SongInsertRequest>(req);
        }
    }
}

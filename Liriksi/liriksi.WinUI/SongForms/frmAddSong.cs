using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WinUI.SongForms.SongUtilForms;
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
        APIService _songService = new APIService("song");
        APIService _performerService = new APIService("performer");

        //genericki
        APIService _albumService = new APIService("album");

        public frmAddSong()
        {
            InitializeComponent();
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            frmAddAlbum frm = new frmAddAlbum();
            frm.Show();
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {
            //Provjeriti todo
            SongInsertRequest req = new SongInsertRequest();
            req.Title = txtName.Text;
            req.Text = txtLyrics.Text;
            req.AlbumId = (int)cmbAlbum.SelectedValue;
            req.PerformerId = (int)cmbPerformer.SelectedValue;

            await _songService.Insert<SongInsertRequest>(req);
            this.Close();
            frmSong frm = new frmSong();
            frm.Show();
            frm.MdiParent = Application.OpenForms["frmIndex"];      
            frm.WindowState = FormWindowState.Maximized;
        }

        private async void frmAddSong_Load(object sender, EventArgs e)
        {

            cmbPerformer.DataSource = await _performerService.Get<List<Performer>>(null);
            cmbPerformer.DisplayMember = "ArtisticName";
            cmbPerformer.ValueMember = "Id";

            cmbAlbum.DataSource = await _albumService.Get<List<Album>>(null);
            cmbAlbum.DisplayMember = "Name";
            cmbAlbum.ValueMember = "Id";
        }

        private void btnAddPerformer_Click(object sender, EventArgs e)
        {
            frmAddPerformer frm = new frmAddPerformer();
            frm.Show();
        }

        private void cmbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

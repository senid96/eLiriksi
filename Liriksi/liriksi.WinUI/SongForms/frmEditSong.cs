using liriksi.Model;
using liriksi.Model.Requests;
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
    public partial class frmEditSong : Form
    {
        private readonly APIService _songService = new APIService("song");
        private readonly APIService _albumService = new APIService("album");
        private readonly APIService _performerService = new APIService("performer");

        int _songId, _albumId, _performerId;

        private async void cmbPerformer_DropDownClosed(object sender, EventArgs e)
        {

            cmbAlbum.DataSource = await _albumService.Get<List<Album>>(cmbPerformer.SelectedValue, "GetAlbumsByPerformerId");
            cmbAlbum.DisplayMember = "Name";
            cmbAlbum.ValueMember = "Id";
        }

        private void frmEditSong_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private async void btnSaveEditedSong_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                SongInsertRequest req = new SongInsertRequest();
                req.Title = txtName.Text;
                req.Text = txtLyrics.Text;
                req.AlbumId = (int)cmbAlbum.SelectedValue;

                await _songService.Update<SongGetRequest>(_songId, req);
                Helper.HelperMethods.CloseAllForms();
                frmSong frm = new frmSong();
                frm.MdiParent = Application.OpenForms["frmIndex"];
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        public frmEditSong(int songId)
        {
            InitializeComponent();
            _songId = songId;
        }

        private async void frmEditSong_Load(object sender, EventArgs e)
        {
            SongGetRequest song = await _songService.GetById<SongGetRequest>(_songId, "GetSongById");


            cmbPerformer.DataSource = await _performerService.Get<List<Performer>>(null, "GetPerformers");
            cmbPerformer.DisplayMember = "ArtisticName";
            cmbPerformer.ValueMember = "Id";
            cmbPerformer.SelectedValue = song.Album.PerformerId;

            cmbAlbum.DataSource = await _albumService.Get<List<Album>>(cmbPerformer.SelectedValue, "GetAlbumsByPerformerId");
            cmbAlbum.DisplayMember = "Name";
            cmbAlbum.ValueMember = "Id";
            cmbAlbum.SelectedValue = song.Album.Id;

            txtName.Text = song.Title;
            txtLyrics.Text = song.Text;

        }
    }
}

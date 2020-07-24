using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using liriksi.Model.Requests;
using liriksi.WinUI.Helper;

namespace liriksi.WinUI.SongForms
{
    public partial class frmSongDetails : Form
    {
        private readonly int? _id = null;
        private readonly APIService _songService = new APIService("song");
        public frmSongDetails(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void FrmSongDetails_Load(object sender, EventArgs e)
        {
            if (!_id.Equals(null))
            {
                SongGetRequest song = await _songService.GetById<SongGetRequest>(_id, null);
                txtboxLyrics.Text = song.Text;
                txtBoxTitle.Text = song.Title;
                txtboxAlbum.Text = song.Album.Name;
                txtboxGenre.Text = song.Album.Genre.Name;
                picboxAlbum.Image = ImageHelperMethods.ResizeImage(ImageHelperMethods.PrepareImgForDisplayFromDB(song.Album.Image), 100, 100);
            }
        }

        private void TxtboxLyrics_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

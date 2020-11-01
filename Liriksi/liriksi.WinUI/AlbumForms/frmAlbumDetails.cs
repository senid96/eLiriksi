using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liriksi.WinUI.AlbumForms
{
    public partial class frmAlbumDetails : Form
    {
        APIService _albumService = new APIService("album");
        APIService _songService = new APIService("song");
        private int _id;
        public frmAlbumDetails(int id)
        {
            InitializeComponent();
            _id = id;
            dgvAlbumSongs.AutoGenerateColumns = false;
        }

        private async void frmAlbumDetails_Load(object sender, EventArgs e)
        {
            Album album = await _albumService.GetById<Album>(_id, "GetAlbumById");
            txtTitle.Text = album.Name;
            txtYearRelease.Text = album.YearRelease.ToString();
            txtGenre.Text = album.Genre.Name;
            txtPerformer.Text = album.Performer.Name;

            //prepare image for display
            if (album.Image.Length != 0)
            {
                byte[] imgData = album.Image;
                MemoryStream stream = new MemoryStream(imgData);
                picboxAlbum.Image = ImageHelperMethods.ResizeImage( Image.FromStream(stream),140,120);
            }
            //end prepare image

            //load songs for album
            dgvAlbumSongs.DataSource = await _songService.GetById<List<SongGetRequest>>(_id, "GetSongsByAlbum");
        }
    }
}

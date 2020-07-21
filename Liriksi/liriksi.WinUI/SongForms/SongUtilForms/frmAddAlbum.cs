using liriksi.Model;
using liriksi.WinUI.SongForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liriksi.WinUI.UtilForms
{
    public partial class frmAddAlbum : Form
    {
        APIService _genreService = new APIService("genre");
        APIService _albumService = new APIService("album");
        public frmAddAlbum()
        {
            //var a = _genre.Get<List<Genre>>(//todo);
            InitializeComponent();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            this.Close(); 
            frmAddGenre frm = new frmAddGenre();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.Show();
        }

        private async void frmAddAlbum_Load(object sender, EventArgs e)
        {
            cmbYear.DataSource = Enumerable.Range(1900, 130).ToList();
            var genres = await _genreService.Get<List<Genre>>(null);
            cmbGenre.DataSource = genres;
            cmbGenre.DisplayMember = "Name";
            cmbGenre.ValueMember = "Id";
        }

        private async void finishAlbum_Click(object sender, EventArgs e)
        {
            Album obj = new Album() { Name = txtTitle.Text, GenreId = (int)cmbGenre.SelectedValue, YearRelease = (int)cmbYear.SelectedValue };
            await _albumService.Insert<Album>(obj);
            this.Close();
        }

        private void frmAddAlbum_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAddSong frm = new frmAddSong();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}

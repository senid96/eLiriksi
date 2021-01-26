using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WinUI.Helper;
using liriksi.WinUI.SongForms;
using liriksi.WinUI.SongForms.AlbumForms;
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

namespace liriksi.WinUI.UtilForms
{
    public partial class frmAddAlbum : Form
    {
        APIService _genreService = new APIService("genre");
        APIService _albumService = new APIService("album");
        APIService _performerService = new APIService("performer");
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
            var genres = await _genreService.Get<List<Genre>>(null, "GetGenres");
            cmbGenre.DataSource = genres;
            cmbGenre.DisplayMember = "Name";
            cmbGenre.ValueMember = "Id";

            var performers = await _performerService.Get<List<Performer>>(null, "GetPerformers");
            cmbPerformer.DataSource = performers;
            cmbPerformer.DisplayMember = "ArtisticName";
            cmbPerformer.ValueMember = "Id";
        }

        private async void finishAlbum_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                
                if (picboxAlbum.Image == null)
                {
                    errorProvider.SetError(picboxAlbum, "Image is required");
                    return;
                }
                else
                {
                    errorProvider.SetError(picboxAlbum, null);
                }
                

                byte[] ImageData = ImageHelperMethods.PrepareImgForDB(picboxAlbum.Image);

                AlbumInsertRequest obj = new AlbumInsertRequest() { Name = txtTitle.Text, GenreId = (int)cmbGenre.SelectedValue, YearRelease = (int)cmbYear.SelectedValue, Image = ImageData, PerformerId = (int)cmbPerformer.SelectedValue, Description = txtAbout.Text };
                await _albumService.Insert<AlbumInsertRequest>(obj, "InsertAlbum");
                this.Close();
            }
           
        }

        private void frmAddAlbum_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAlbum frm = new frmAlbum();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        //upload slike
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                //ako si odabrao sliku prikazi, ako si zatvorio dialog i nisi odabrao - nemoj prikazivati
                //padne ako se ovako ne stavi
                if (!openFileDialog.FileName.Equals(""))
                {
                    Bitmap img = new Bitmap(openFileDialog.FileName);
                    picboxAlbum.Image = ImageHelperMethods.ResizeImage(img, 120, 120);
                }
            }
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider.SetError(txtTitle, "Required field!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTitle, null);
            }
        }

        private void txtAbout_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAbout.Text))
            {
                errorProvider.SetError(txtAbout, "Required field!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAbout, null);
            }
        }

        private void frmAddAlbum_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = false;
        }
    }
}

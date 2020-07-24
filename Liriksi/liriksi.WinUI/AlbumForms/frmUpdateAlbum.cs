using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.Model.Requests.album;
using liriksi.WinUI.Helper;
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

namespace liriksi.WinUI.AlbumForms
{
    public partial class frmUpdateAlbum : Form
    {
        private readonly int _albumId;
        APIService _albumService = new APIService("album");
        APIService _performerService = new APIService("performer");
        APIService _genreService = new APIService("genre");
        public frmUpdateAlbum(int albumId)
        {
            InitializeComponent();
            _albumId = albumId;
        }

        private async void frmUpdateAlbum_Load(object sender, EventArgs e)
        {
            //get object we want to update
            Album obj = await _albumService.GetById<Album>(_albumId, null);

            //get all performers
            cmbPerformer.DataSource = await _performerService.Get<List<Performer>>(null, null);
            cmbPerformer.DisplayMember = "ArtisticName";
            cmbPerformer.ValueMember = "Id";
            cmbPerformer.SelectedValue = obj.Performer.Id; //set selected value from db object

            //get all genres
            cmbGenre.DataSource = await _genreService.Get<List<Genre>>(null, null);
            cmbGenre.DisplayMember = "Name";
            cmbGenre.ValueMember = "Id";
            cmbGenre.SelectedValue = obj.Genre.Id; //set selected value from db object

            
            cmbYear.DataSource = Enumerable.Range(1900, 130).ToList();
            txtTitle.Text = obj.Name;

            //prepare image for display
            if (obj.Image.Length != 0)
            {
                picboxAlbum.Image = ImageHelperMethods.ResizeImage(ImageHelperMethods.PrepareImgForDisplayFromDB(obj.Image),120,140);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            byte[] imgByte = ImageHelperMethods.PrepareImgForDB(picboxAlbum.Image);
            AlbumInsertRequest obj = new AlbumInsertRequest
            {
                Name = txtTitle.Text,
                YearRelease = Convert.ToInt32(cmbYear.SelectedValue),
                GenreId = Convert.ToInt32(cmbGenre.SelectedValue),
                PerformerId = Convert.ToInt32(cmbPerformer.SelectedValue),
                Image = imgByte
            };
            await _albumService.Update<AlbumInsertRequest>(_albumId, obj);
            this.Close();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            //upload slike
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
                        picboxAlbum.Image =ImageHelperMethods.ResizeImage(img, 120, 120);
                    }
                }
            }

        private void frmUpdateAlbum_FormClosed(object sender, FormClosedEventArgs e)
        {
                frmAlbum frm = new frmAlbum();
                frm.MdiParent = Application.OpenForms["frmIndex"];
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
        }
    }
    }

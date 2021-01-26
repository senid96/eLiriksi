using liriksi.Model;
using liriksi.WinUI.Helper;
using liriksi.WinUI.PerformerForms;
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

namespace liriksi.WinUI.SongForms.SongUtilForms
{
    public partial class frmAddPerformer : Form
    {
        private readonly APIService _performerService = new APIService("performer");
        public frmAddPerformer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAddPerformer_Load(object sender, EventArgs e)
        {

        }

        private async void btnAddPerformer_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (picBoxPerformer.Image == null)
                {
                    errorProvider.SetError(picBoxPerformer, "Image is required");
                    return;
                }
                else
                {
                    errorProvider.SetError(picBoxPerformer, null);
                }

                byte[] img = ImageHelperMethods.PrepareImgForDB(picBoxPerformer.Image);
                Performer obj = new Performer() { Name = txtName.Text, Surname = txtSurname.Text, ArtisticName = txtArtisticName.Text, Image = img, About = txtAbout.Text };
                await _performerService.Insert<Performer>(obj, "AddPerformer");
                this.Close();
            }
           
        }

        private void frmAddPerformer_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPerformer frm = new frmPerformer();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
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
                    picBoxPerformer.Image = ImageHelperMethods.ResizeImage(img, 150, 120);
                }
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "Required field!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtName, null);
            }
        }

        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                errorProvider.SetError(txtSurname, "Required field!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSurname, null);
            }
        }

        private void txtArtisticName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArtisticName.Text))
            {
                errorProvider.SetError(txtArtisticName, "Required field!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtArtisticName, null);
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

        private void frmAddPerformer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}

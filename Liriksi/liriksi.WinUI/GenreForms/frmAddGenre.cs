using liriksi.Model;
using liriksi.WinUI.Helper;
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
    public partial class frmAddGenre : Form
    {
        private readonly APIService _genreService = new APIService("genre");
        public frmAddGenre()
        {
            InitializeComponent();
        }

        private async void btnAddGenre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGenreName.Text))
            {
                errorProvider1.SetError(txtGenreName, "Required field!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtGenreName, null);
                errorProvider1.Clear();
            }
            Genre obj = new Genre { Name = txtGenreName.Text };
            await _genreService.Insert<Genre>(obj, "AddGenre");
            this.Close();
        }

        
        private void frmAddGenre_Load(object sender, EventArgs e)
        {

        }
        private void frmAddGenre_FormClosed(object sender, FormClosedEventArgs e)
        {
            HelperMethods.CloseAllForms();
            frmAddAlbum frm = new frmAddAlbum();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void frmAddGenre_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

using liriksi.Model;
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
        APIService _genreService = new APIService("genre");
        public frmAddGenre()
        {
            InitializeComponent();
        }

        private async void btnAddGenre_Click(object sender, EventArgs e)
        {
            await _genreService.Insert<Genre>(txtName.Text);
            this.Close();
            frmAddAlbum frm = new frmAddAlbum();
            frm.Show();
        }

        private void frmAddGenre_Load(object sender, EventArgs e)
        {

        }
        private void frmAddGenre_FormClosing(Object sender, FormClosingEventArgs e)
        {
            frmAddAlbum frm = new frmAddAlbum();
            frm.Show();
            // Do something
        }
    }
}

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
        private readonly APIService _genreService = new APIService("genre");
        public frmAddGenre()
        {
            InitializeComponent();
        }

        private async void btnAddGenre_Click(object sender, EventArgs e)
        {
            Genre obj = new Genre { Name = txtGenreName.Text };
            await _genreService.Insert<Genre>(obj);
            this.Close();
        }

        private void frmAddGenre_Load(object sender, EventArgs e)
        {

        }
        private void frmAddGenre_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseAllForm();
            frmAddAlbum frm = new frmAddAlbum();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        public void CloseAllForm()
        {
            for (int x = 0; x < Application.OpenForms.Count; x++)
            {
                if (Application.OpenForms[x] != Application.OpenForms["frmIndex"])
                    Application.OpenForms[x].Close();
            }
        }
    }
}

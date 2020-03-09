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
    public partial class frmAddAlbum : Form
    {
        APIService _genre = new APIService("genre");
        public frmAddAlbum()
        {
            //var a = _genre.Get<List<Genre>>(//todo);
            InitializeComponent();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            frmAddGenre frm = new frmAddGenre();
            frm.Show();
        }
    }
}

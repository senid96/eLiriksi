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
            await _genreService.Insert<string>(txtName.Text);
            this.Close();
        }
    }
}

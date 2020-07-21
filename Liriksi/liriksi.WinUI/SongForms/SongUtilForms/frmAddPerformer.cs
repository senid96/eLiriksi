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
            Performer obj = new Performer() { Name = txtName.Text, Surname = txtSurname.Text, ArtisticName = txtArtisticName.Text };
            await _performerService.Insert<Performer>(obj);
            this.Close();
        }

        private void frmAddPerformer_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAddSong frm = new frmAddSong();
            frm.Show();
        }
    }
}

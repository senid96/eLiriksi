using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using liriksi.Model;
using liriksi.Model.Requests;

namespace liriksi.WinUI.SongForms
{
    public partial class frmSong : Form
    {
        private readonly APIService _songService = new APIService("song");
        public frmSong()
        {
            InitializeComponent();
        }

        private async void BtnSongSearch_Click(object sender, EventArgs e)
        {
            var temp = new SongSearchRequest() { Title = txtboxTitle.Text, Text = txtBoxLyrics.Text };

            var data = await _songService.Get<List<SongGetRequest>>(temp);
            dgvSong.DataSource = data;           
        }

        private void DgvSong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvSong_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvSong.SelectedRows[0].Cells[0].Value.ToString();
            frmSongDetails frm = new frmSongDetails(int.Parse(id));
            frm.Show();
        }

        private async void FrmSong_Load(object sender, EventArgs e)
        {
            dgvSong.DataSource = await _songService.Get<List<SongGetRequest>>(null);
        }

        private void BtnClearInputs_Click(object sender, EventArgs e)
        {
            txtBoxLyrics.Text = "";
            txtboxTitle.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using liriksi.Model.Requests;

namespace liriksi.WinUI.SongForms
{
    public partial class frmSongDetails : Form
    {
        private readonly int? _id;
        private readonly APIService _songService = new APIService("song");
        public frmSongDetails(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void FrmSongDetails_Load(object sender, EventArgs e)
        {
            if (!_id.Equals(null))
            {
                SongGetRequest song = await _songService.GetById<SongGetRequest>(_id);
                txtboxLyrics.Text = song.Text;
                txtBoxTitle.Text = song.Title;
            }
        }

        private void TxtboxLyrics_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

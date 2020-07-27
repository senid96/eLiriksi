using liriksi.Model.Requests.rates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liriksi.WinUI.RatingForms
{
    public partial class frmSongRating : Form
    {
        private readonly APIService _ratingService = new APIService("rating");
        public frmSongRating()
        {
            InitializeComponent();
        }

        private async void frmSongRating_Load(object sender, EventArgs e)
        {
            dgvSongRating.DataSource = await _ratingService.Get<List<AverageRate>>(null, "GetSongRates");
        }

        private void dgvSongRating_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvSongRating.SelectedRows[0].Cells[0].Value.ToString();
            frmSongRatingDetails frm = new frmSongRatingDetails(int.Parse(id));
            frm.Show();
        }
    }
}

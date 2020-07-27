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
    public partial class frmAlbumRating : Form
    {
        private readonly APIService _rateService = new APIService("rating");
        public frmAlbumRating()
        {
            InitializeComponent();
        }

        private async void frmAlbumRating_Load(object sender, EventArgs e)
        {
            dgvAlbumRate.DataSource = await _rateService.Get<List<AverageRate>>(null, "GetAlbumRates");
        }

        private void dgvAlbumRate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAlbumRate_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvAlbumRate.SelectedRows[0].Cells[0].Value.ToString();
            frmAlbumRatingDetails frm = new frmAlbumRatingDetails(int.Parse(id));
            frm.Show();
        }
    }
}

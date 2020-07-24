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

        private void frmSongRating_Load(object sender, EventArgs e)
        {
            dgvSongRating.DataSource = _ratingService.Get<AverageRate>(null, "GetSongRates");
        }
    }
}

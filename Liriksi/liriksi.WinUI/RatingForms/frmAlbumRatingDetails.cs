using liriksi.Model;
using liriksi.Model.Requests;
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
    public partial class frmAlbumRatingDetails : Form
    {
        private readonly APIService _ratingService = new APIService("rating");
        private int _albumId;
        public frmAlbumRatingDetails(int id)
        {
            InitializeComponent();
            _albumId = id;
            dgvAlbumRatingDetails.AutoGenerateColumns = false;
        }

        private async void frmRating_Load(object sender, EventArgs e)
        {
            dgvAlbumRatingDetails.DataSource = await _ratingService.GetById<List<UserAlbumRateGetRequest>>(_albumId, "GetRatesByAlbum");
        }
    }
}

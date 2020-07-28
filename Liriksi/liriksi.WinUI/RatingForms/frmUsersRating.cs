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
using liriksi.Model.Requests.rates;

namespace liriksi.WinUI.RatingForms
{
    public partial class frmUsersRating : Form
    {
        private readonly APIService _ratingService = new APIService("rating");
        private readonly APIService _userService = new APIService("user");
        public frmUsersRating()
        {
            InitializeComponent();
            dgvUsersRating.AutoGenerateColumns = false;
        }

        private async void frmUsersRating_Load(object sender, EventArgs e)
        {
            cmbUser.DataSource = await _userService.Get<List<UserGetRequest>>(null, null);
            cmbUser.ValueMember = "Id";
            cmbUser.DisplayMember = "FullName";

            // Bind combobox to dictionary
            Dictionary<string, string> viewChoiceValues = new Dictionary<string, string>();
            viewChoiceValues.Add("0", "Album");
            viewChoiceValues.Add("1", "Song");
            cmbChoseView.DataSource = new BindingSource(viewChoiceValues, null);
            cmbChoseView.DisplayMember = "Value";
            cmbChoseView.ValueMember = "Key";
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            int userId = (int)cmbUser.SelectedValue;
            int viewChoice = Convert.ToInt32(cmbChoseView.SelectedValue);

            // 0 - album
            // 1 - song
            if (viewChoice == 1)
                dgvUsersRating.DataSource = await _ratingService.GetById<List<UserAlbumRateGetRequest>>(userId, "GetSongRatesByUser"); 
            else 
                dgvUsersRating.DataSource = await _ratingService.GetById<List<UserAlbumRateGetRequest>>(userId, "GetAlbumRatesByUser");

        }

        private void dgvUsersRating_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

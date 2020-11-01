using liriksi.Model;
using liriksi.Model.Requests.performer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liriksi.WinUI.PerformerForms
{
    public partial class frmPerformer : Form
    {
        private readonly APIService _performerService = new APIService("performer");
        public frmPerformer()
        {
            
            InitializeComponent();
            dgvPerformer.AutoGenerateColumns = false;
        }

        private async void frmPerformer_Load(object sender, EventArgs e)
        {
            dgvPerformer.DataSource = await _performerService.Get<List<Performer>>(null, "GetPerformers");
        }

        private async void btnSearchPerformer_Click(object sender, EventArgs e)
        {
            PerformerSearchRequest searchObj = new PerformerSearchRequest
            {
                Name = txtboxName.Text,
                Surname = txtboxSurname.Text,
                ArtisticName = txtboxArtisticName.Text
            };

            dgvPerformer.DataSource = await _performerService.Get<List<Performer>>(searchObj, "GetPerformers");
        }
    }
}

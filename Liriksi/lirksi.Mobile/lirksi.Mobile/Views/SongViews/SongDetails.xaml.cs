using liriksi.Model.Requests;
using lirksi.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lirksi.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SongDetails : ContentPage
    {

        private SongDetailsViewModel model = null;
      
        public SongDetails(int songId)
        {
            InitializeComponent();
            BindingContext = model = new SongDetailsViewModel()
            {
                _songId = songId
            };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Rate_Clicked(object sender, EventArgs e)
        {
            await model.RateSong();
        }

        private void PickerRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PickerRate.SelectedIndex == -1)
            {
               
            }
            else
            {
                model.UserRate.Rate = Convert.ToInt32(PickerRate.SelectedItem);
            }
        }
    }
}
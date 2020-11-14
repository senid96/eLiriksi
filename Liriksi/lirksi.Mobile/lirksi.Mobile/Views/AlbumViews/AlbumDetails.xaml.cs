using liriksi.Model;
using liriksi.Model.Requests;
using lirksi.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lirksi.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumDetails : ContentPage
    {
        public AlbumDetailsViewModel model { get; set; }
        public AlbumDetails(int albumId)
        {
            InitializeComponent();
            BindingContext = model = new AlbumDetailsViewModel()
            {
                _albumId = albumId
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

            //if its already rated, disable rate feature
            if (model.UserRate != null)
            {
                PickerRate.IsEnabled = false;
                Comment.IsEnabled = false;
                Rate.IsEnabled = false;
            }
            else
            {
                //instance userRate VM, so it can be used with picker and rate feature
                model.UserRate = new liriksi.Model.UsersAlbumRate();
            }
        }

        private void SongList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as SongGetRequest;
            Navigation.PushAsync(new SongDetails(item.Id));
        }

        private async void Rate_Clicked(object sender, EventArgs e)
        {
            await model.RateAlbum();
            //call onAppearing to refresh rateFeature(to disable it)
            OnAppearing();
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
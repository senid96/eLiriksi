using liriksi.Model.Requests;
using lirksi.Mobile.Services.OfflineModeServices;
using lirksi.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        private SongDetailsViewModel model { get; set; }
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
            await model.GetRecommendedSongs();
            

            //if its already rated, disable rate feature
            if(model.UserRate != null)
            {
                PickerRate.IsEnabled = false;
                Comment.IsEnabled = false;
                Rate.IsEnabled = false;
            }
            else
            {
                //instance userRate VM, so it can be used with picker and rate feature
                model.UserRate = new liriksi.Model.UsersSongRate();
            }
        }

        private async void Rate_Clicked(object sender, EventArgs e)
        {
            await model.RateSong();
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

        private async void RecommendedList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as SongGetRequest;
            await Navigation.PushAsync(new SongDetails(item.Id));
        }

        private async void DownloadSongBtn_Clicked(object sender, EventArgs e)
        {
            SongGetRequest obj = model.GetSongByIdOffline(model._songId);
            if(obj != null)
            {
                await Application.Current.MainPage.DisplayAlert("Warning", "You have already downloaded this song.", "OK");
                return;
            }
            else
            {
                await model.DownloadSongOffline();
                await Application.Current.MainPage.DisplayAlert("Success", "Successfully downloaded!", "OK");
            }
        }
    }
}
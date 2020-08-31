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
        public AlbumDetails(Album album)
        {
            InitializeComponent();
            BindingContext = model = new AlbumDetailsViewModel()
            {
                Album = album
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as SongGetRequest;
            Application.Current.MainPage.DisplayAlert("Lyrics",item.Text.ToString(), "Ok");
        }
    }
}
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
        }

        private void SongList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as SongGetRequest;
            Navigation.PushAsync(new SongDetails(item.Id));
        }
    }
}
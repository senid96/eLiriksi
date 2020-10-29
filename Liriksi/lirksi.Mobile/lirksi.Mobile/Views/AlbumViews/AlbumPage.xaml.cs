using liriksi.Model;
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
    public partial class AlbumPage : ContentPage
    {
        public AlbumViewModel model { get; set; }
        public AlbumPage()
        {
            InitializeComponent();
            BindingContext = model = new AlbumViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            PerformerPicker.SelectedIndex = 0;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Album;
            await Navigation.PushAsync(new AlbumDetails(item.Id));
        }

        private async void PerformerPicker_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (PerformerPicker.SelectedIndex == -1) { }
            else {
                await model.GetAlbums();
            }
        }
    }
}
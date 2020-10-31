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
    public partial class SongPage : ContentPage
    {
        public SongViewModel model { get; set; }
        public SongPage()
        {
            InitializeComponent();
            BindingContext = model = new SongViewModel();
        }

        /* on song list click, open song details */
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as SongGetRequest;
            await Navigation.PushAsync(new SongDetails(item.Id));
        }

        private async void SearchButton_Clicked(object sender, EventArgs e)
        {
            await model.SearchSongs();
        }
    }
}
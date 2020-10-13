using liriksi.Model.Requests;
using liriksi.Model.Requests.rates;
using lirksi.Mobile.ViewModels.RatingViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lirksi.Mobile.Views.RatingViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Ratings : ContentPage
	{
        public RatingViewModel model { get; set; }
        public Ratings ()
		{
			InitializeComponent ();
            BindingContext = model = new RatingViewModel();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void SongRateList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as AverageRate;
            await Navigation.PushAsync(new SongDetails(item.Id));
        }

        private async void AlbumRateList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as AverageRate;
            await Navigation.PushAsync(new AlbumDetails(item.Id));
        }
    }
}
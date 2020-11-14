using liriksi.Model.Requests.rates;
using lirksi.Mobile.ViewModels.AlbumRatingsViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lirksi.Mobile.Views.AlbumRatingsViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlbumRatings : ContentPage
	{
        public AlbumRatingsViewModel model { get; set; }
		public AlbumRatings ()
		{
			InitializeComponent ();
            BindingContext = model = new AlbumRatingsViewModel();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.GetTop10Albums();
        }

        private async void AlbumRateList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as AverageRate;
            await Navigation.PushAsync(new AlbumDetails(item.Id));
        }
    }
}
using liriksi.Model;
using lirksi.Mobile.ViewModels.PerformerViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lirksi.Mobile.Views.PerformerViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PerformerPage : ContentPage
	{
        public PerformerViewModel model;
		public PerformerPage ()
		{
			InitializeComponent ();
            BindingContext = model = new PerformerViewModel();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.GetPerformers();
        }

        private async void PerformerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Performer;
            await Navigation.PushAsync(new PerformerDetails(item.Id));
        }

        private async void PerformerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            await model.GetPerformersBySearchObj();
        }

        private async void PerformerSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            await model.GetPerformersBySearchObj();

        }

        private async void PerformerArtisticName_TextChanged(object sender, TextChangedEventArgs e)
        {
            await model.GetPerformersBySearchObj();
        }

        private void AddPerformerBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPerformer());
        }
    }
}
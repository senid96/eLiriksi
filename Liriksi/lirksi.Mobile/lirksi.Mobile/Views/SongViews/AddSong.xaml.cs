using lirksi.Mobile.ViewModels.SongViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lirksi.Mobile.Views.SongViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddSong : ContentPage
	{
        public AddSongViewModel model { get; set; }
		public AddSong ()
		{
			InitializeComponent ();
            BindingContext = model = new AddSongViewModel();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.GetPerformers();
            PerformerPicker.SelectedIndex = 0;
            await model.GetAlbums();
            AlbumPicker.SelectedIndex = 0;
        }

        private async void PerformerPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PerformerPicker.SelectedIndex != -1)
                await model.GetAlbums();

            AlbumPicker.SelectedIndex = 0;
        }

        private async void SaveSongBtn_Clicked(object sender, EventArgs e)
        {
            await model.AddSong();
            await Navigation.PushAsync(new SongPage());
        }
    }
}
using lirksi.Mobile.ViewModels.AlbumViewModels;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lirksi.Mobile.Views.AlbumViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddAlbum : ContentPage
	{
        public AddAlbumViewModel model { get; set; }
        public AddAlbum ()
		{
			InitializeComponent ();
            BindingContext = model = new AddAlbumViewModel();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.GetPerformers();
            PerformerPicker.SelectedIndex = 0;
            await model.GetGenres();
            GenrePicker.SelectedIndex = 0;
        }

        private async void UploadImage_Clicked(object sender, EventArgs e)
        {
            byte[] bytes;
            var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
            {
                PhotoSize = PhotoSize.MaxWidthHeight,
                CompressionQuality = 50
            });

            if (file != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    file.GetStream().CopyTo(memoryStream);
                    bytes = memoryStream.ToArray();
                }
                AlbumImage.Source = ImageSource.FromStream(() => file.GetStream());
                AlbumImage.WidthRequest = 200;
                AlbumImage.HeightRequest = 200;

                //set to viewmodel
                model.AlbumReq.Image = bytes;
            }
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            await model.AddAlbum();
            await Navigation.PushAsync(new AlbumPage());
        }
    }
}
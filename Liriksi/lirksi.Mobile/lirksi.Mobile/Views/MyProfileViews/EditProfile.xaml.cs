using Acr.UserDialogs;
using lirksi.Mobile.ViewModels.MyProfileViewModels;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lirksi.Mobile.Views.MyProfileViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditProfile : ContentPage
	{
        public EditProfileViewModel model { get; set; }
		public EditProfile ()
		{
			InitializeComponent ();
            BindingContext = model = new EditProfileViewModel();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.LoadUser();
        }

        private async void ChangeImage_Clicked(object sender, EventArgs e)
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
                NewImage.Source = ImageSource.FromStream(() => file.GetStream());
                NewImage.WidthRequest = 200;
                NewImage.HeightRequest = 200;
                //
              

                //set to viewmodel
                model.User.Image = bytes;
            }
        }

        private async void SaveProfileChanges_Clicked(object sender, EventArgs e)
        {
            if (ValidationHelpers.ValidationHelper.IsAnyNullOrEmpty(model.User))
            {
                UserDialogs.Instance.Toast(ValidationHelpers.MessagesResource.all_fields_required);
                return;
            }
            await model.SaveChanges();
            await Navigation.PushAsync(new MyProfile());
        }
    }
}
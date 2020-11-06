using liriksi.Model.Requests;
using lirksi.Mobile.ViewModels;
using lirksi.Mobile.Views.MyProfileViews;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lirksi.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyProfile : ContentPage
	{
        public MyProfileViewModel model { get; set; }
        public MyProfile ()
		{
			InitializeComponent ();
            BindingContext = model = new MyProfileViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.LoadUser();
        }

        private void EditProfile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditProfile());
        }
    }
}
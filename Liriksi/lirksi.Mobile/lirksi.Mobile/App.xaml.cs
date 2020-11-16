using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using lirksi.Mobile.Services;
using lirksi.Mobile.Views;
using Xamarin.Essentials;
using liriksi.Model;
using liriksi.Model.Requests;

namespace lirksi.Mobile
{
    public partial class App : Application
    {
        private readonly APIService _userService = new APIService("user");

        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
        }

        protected async override void OnStart()
        {
            try
            {
                string username = await SecureStorage.GetAsync("username");
                string password = await SecureStorage.GetAsync("password");

                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    APIService._username = username;
                    APIService._password = password;

                    if (Connectivity.NetworkAccess > NetworkAccess.Local)
                    {
                        try
                        {
                            APIService._currentUser = await _userService.Get<UserGetRequest>(null, "GetMyProfile");
                            Current.MainPage = new MainPage();
                            return;
                        }
                        catch (Exception)
                        {
                            await Current.MainPage.DisplayAlert("Error", "Session has expired. Please log in again.", "OK");
                        }
                    }
                    else
                    {
                        Current.MainPage = new MainPage();
                        return;
                    }
                }

            }
            catch (Exception)
            {
                // Possible that device doesn't support secure storage on device.
            }

            Current.MainPage = new LoginPage();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}

using lirksi.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace lirksi.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _loginService = new APIService("User");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }
        async Task Login()
        {
            IsBusy = true;
            //APIService._username = Username;     
            //APIService._password = Password;

            //za brzi razvoj samo TODO obrisati kasnije
            APIService._username = "testiranje"; 
            APIService._password = "testiranje";
            try
            {
                APIService._currentUser = await _loginService.Get<liriksi.Model.User>(null, "GetMyProfile");
                if (APIService._currentUser != null)
                {
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Autentikacija", "Username or password incorect", "Ok");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Exception Autentikacija", "Username or password incorect", "Ok");
            }
        }
    }
}

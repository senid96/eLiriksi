using System;
using System.Collections.Generic;
using System.Text;

namespace lirksi.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
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
    }
}

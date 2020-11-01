using liriksi.Model;
using liriksi.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace lirksi.Mobile.ViewModels
{
    public class MyProfileViewModel: BaseViewModel
    {
        public User User { get; set; }

        public MyProfileViewModel()
        {
            Title = "My profile";
        }
    }
}

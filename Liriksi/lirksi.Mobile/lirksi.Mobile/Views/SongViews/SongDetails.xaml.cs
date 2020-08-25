using liriksi.Model.Requests;
using lirksi.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lirksi.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SongDetails : ContentPage
    {
        private SongDetailsViewModel model = null;
        public SongDetails(SongGetRequest song)
        {
            InitializeComponent();
            BindingContext = model = new SongDetailsViewModel()
            {
                Song = song
            };
        }
    }
}
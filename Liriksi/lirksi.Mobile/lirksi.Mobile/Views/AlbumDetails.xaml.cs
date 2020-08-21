using liriksi.Model;
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
    public partial class AlbumDetails : ContentPage
    {
        public AlbumDetailsViewModel model { get; set; }
        public AlbumDetails(Album album)
        {
            InitializeComponent();
            BindingContext = model = new AlbumDetailsViewModel()
            {
                Album = album
            };
        }
    }
}
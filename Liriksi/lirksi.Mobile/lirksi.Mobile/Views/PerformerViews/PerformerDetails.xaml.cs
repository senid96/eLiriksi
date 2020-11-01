using lirksi.Mobile.ViewModels.PerformerViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lirksi.Mobile.Views.PerformerViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PerformerDetails : ContentPage
	{
        public PerformerDetailsViewModel model { get; set; }
        public PerformerDetails(int performerId)
        {
            BindingContext = model = new PerformerDetailsViewModel()
            {
                _performerId = performerId
            };
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.GetPerformer();
        }
    }
}
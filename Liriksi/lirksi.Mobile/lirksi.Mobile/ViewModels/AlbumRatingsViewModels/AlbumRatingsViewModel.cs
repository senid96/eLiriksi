using liriksi.Model.Requests.rates;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace lirksi.Mobile.ViewModels.AlbumRatingsViewModels
{
    public class AlbumRatingsViewModel: BaseViewModel
    {
        /* services */
        private readonly APIService _ratingService = new APIService("rating");
        
        /* viewModels & lists */
        public ObservableCollection<AverageRate> AlbumRateList { get; set; } = new ObservableCollection<AverageRate>();

        public AlbumRatingsViewModel()
        {
            Title = "Top rated albums";
        }


        /* methods */
        public async Task GetTop10Albums()
        {
            var albumRateList = await _ratingService.Get<IEnumerable<AverageRate>>(null, "GetAlbumRates");
            AlbumRateList.Clear();
            foreach (var item in albumRateList)
            {
                AlbumRateList.Add(item);
            }
        }
    }
}

using liriksi.Model;
using liriksi.Model.Requests.rates;
using lirksi.Mobile.Views.RatingViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace lirksi.Mobile.ViewModels.RatingViewModels
{
    public class RatingViewModel: BaseViewModel
    {
        /* services */
        private readonly APIService _ratingService = new APIService("rating");


        /* song and album list */
        public ObservableCollection<AverageRate> SongRateList { get; set; } = new ObservableCollection<AverageRate>();
        public ObservableCollection<AverageRate> AlbumRateList { get; set; } = new ObservableCollection<AverageRate>();


        /*---------------------------------------- METHODS ------------------------------------------- */

        public async Task Init()
        {
            await GetTop10Songs();
            await GetTop10Albums();
        }

        public async Task GetTop10Songs()
        {
            var songRateList = await _ratingService.Get<IEnumerable<AverageRate>>(null, "GetSongRates");
            SongRateList.Clear();
            foreach (var item in songRateList)
            {
                SongRateList.Add(item);
            }
        }

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

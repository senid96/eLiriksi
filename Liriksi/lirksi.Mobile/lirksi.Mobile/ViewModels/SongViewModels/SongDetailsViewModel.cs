using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.Model.Requests.rates;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace lirksi.Mobile.ViewModels
{
    public class SongDetailsViewModel:BaseViewModel
    {
        private readonly APIService _songService = new APIService("song");
        private readonly APIService _ratingService = new APIService("rating");
        public int _songId { get; set; }

        private SongGetRequest _songDetail;
        public SongGetRequest SongDetail
        {
            get { return _songDetail; }
            set { SetProperty(ref _songDetail, value); }
        }

        private UsersSongRate _userRate = null;
        public UsersSongRate UserRate
        {
            get { return _userRate; }
            set { SetProperty(ref _userRate, value); }
        }

        public SongDetailsViewModel()
        {
            UserRate = new UsersSongRate();
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            SongDetail = await _songService.GetById<SongGetRequest>(_songId, "GetSongById");
            List<UserSongRateGetRequest> obj = await _ratingService.GetById<List<UserSongRateGetRequest>>(APIService._currentUser.Id, "GetSongRatesByUser");
            UserRate.SongId = SongDetail.Id;
            UserRate.UserId = APIService._currentUser.Id;
            UserRate.Rate = obj.Find(x => x.SongId == UserRate.SongId && x.UserId == UserRate.UserId).Rate;
            UserRate.Comment = obj.Find(x => x.SongId == UserRate.SongId && x.UserId == UserRate.UserId).Comment;
            //todo senid ovo treba da prilikom inita ako je vec ocjenjeno to prikaze.. ako nije omogucit .. to treba uradit
        }

        public ICommand RateSongCommand { get; set; }
        public async Task RateSong()
        {
            await _ratingService.Insert<bool>(UserRate, "RateSong");
        }
    }
}

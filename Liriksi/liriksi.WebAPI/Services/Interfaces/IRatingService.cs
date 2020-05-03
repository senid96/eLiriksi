using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.Model.Requests.rates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services.Interfaces
{
    public interface IRatingService
    {
        bool RateSong(UsersSongRate obj);
        bool RateAlbum(UsersAlbumRate obj);

        List<UsersAlbumRateRequest> GetAlbumRates();
        List<UsersSongRateRequest> GetSongRates();
    }
}

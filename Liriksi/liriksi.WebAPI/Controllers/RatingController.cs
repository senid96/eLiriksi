using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.Model.Requests.rates;
using liriksi.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace liriksi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _service;
        public RatingController(IRatingService service)
        {
            _service = service;
        }
        //todo GET top 10 rejtinga

        [HttpGet("GetSongRates")]
        public List<AverageRate> GetSongRates()
        {
            return _service.GetSongRates();
        }

        [HttpGet("GetAlbumRates")]
        public List<AverageRate> GetAlbumRates()
        {
            return _service.GetAlbumRates();
        }

        [HttpGet("GetUsersAlbumRate")]
        public List<UsersAlbumRateGetRequest> GetRatesByAlbum(int albumId)
        {
            return _service.GetRatesByAlbum(albumId);
        }

        [HttpGet("GetUsersSongRate")]
        public List<UsersSongRateGetRequest> GetUsersRateBySong(int songId)
        {
            return _service.GetRatesBySong(songId);
        }

        [HttpPost("RateSong")]
        public bool RateSong(UsersSongRate obj)
        {
            return _service.RateSong(obj);
        }

        [HttpPost("RateAlbum")]
        public bool RateAlbum(UsersAlbumRate obj)
        {
            return _service.RateAlbum(obj);
        }

       
    }
}
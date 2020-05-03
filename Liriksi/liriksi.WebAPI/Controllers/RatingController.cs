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

        [HttpGet("GetUsersAlbumRate")]
        public List<UsersAlbumRateRequest> GetUsersAlbumRate()
        {
            return _service.GetAlbumRates();
        }

        [HttpGet("GetUsersSongRate")]
        public List<UsersSongRateRequest> GetUsersSongRate()
        {
            return _service.GetSongRates();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using liriksi.Model;
using liriksi.WebAPI.Services;

namespace liriksi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongService _songService;

        //dependency injection (defined in startup.cs : configureservices)
        public SongController(ISongService songService)
        {
            _songService = songService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Song>> GetAllSongs(){
            return _songService.Get().ToList<Song>();
        }

        [HttpGet("{id}")]
        public ActionResult<Song> GetSongById(int id)
        {
            var item = new Song()
            {
                SongId = 3,
                Name = "Fade to black",
                Album = "Black Album"
            };

            return item;
        }

        [HttpPost]
        public Song Insert(Song song)
        {
            return new Song()
            {
                SongId = 3,
                Name = "Fade to black",
                Album = "Black Album"
            };
        }

        [HttpPut("{id}")]
        public Song Update(int id, Song song)
        {
            return new Song()
            {
                SongId = 3,
                Name = "Fade to black",
                Album = "Black Album"
            };
        }
    }
}
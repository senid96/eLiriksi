using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using liriksi.Model;
using liriksi.WebAPI.Services;
using liriksi.Model.Requests;

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
        public ActionResult<List<SongGetRequest>> Get(string songTitle){
            return _songService.Get(songTitle);
        }

        [HttpGet("{id}")]
        public ActionResult<Song> Get(int id)
        {
            return _songService.GetById(id);
        }

        [HttpPost]
        public ActionResult<Song> Insert(SongInsertRequest song)
        {
           return _songService.Insert(song);
        }


    }
}
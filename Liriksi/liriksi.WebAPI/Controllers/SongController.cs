using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using liriksi.Model;
using liriksi.WebAPI.Services;
using liriksi.Model.Requests;
using Microsoft.AspNetCore.Authorization;

namespace liriksi.WebAPI.Controllers
{
    [Authorize]
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
        public ActionResult<List<SongGetRequest>> Get([FromQuery]SongSearchRequest request)
        {
            return _songService.Get(request);
        }

        [HttpGet("GetSongById/{id}")]
        public ActionResult<SongGetRequest> Get(int id)
        {
            return _songService.GetById(id);
        }

        [HttpGet("GetSongsByAlbum/{id}")]
        public ActionResult<List<SongGetRequest>> GetSongsByAlbum(int id)
        {
            return _songService.GetSongsByAlbum(id);
        }

        [HttpPost("AddSong")]
        public ActionResult<SongGetRequest> Insert(SongInsertRequest song)
        {
            return _songService.Insert(song);
        }

        [HttpPut]
        public ActionResult<SongGetRequest> Update(int id, SongInsertRequest song)
        {
            return _songService.Update(id, song);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return _songService.Delete(id);
        }
    }
}
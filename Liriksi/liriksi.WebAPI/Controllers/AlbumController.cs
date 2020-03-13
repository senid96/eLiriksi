using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using liriksi.Model;
using liriksi.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace liriksi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;
        public AlbumController(IAlbumService service)
        {
            _albumService = service;
        }

        [HttpGet]
        public ActionResult<List<Album>> Get()
        {
            return _albumService.Get();
        }

        public ActionResult<Album>Insert(Album album)
        {
            return _albumService.Insert(album);
        }
    }
}
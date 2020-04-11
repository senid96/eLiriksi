using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WebAPI.Services;
using liriksi.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace liriksi.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _service;
        public AlbumController(IAlbumService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Album>> Get(string title)
        {
            return _service.Get(title);
        }

        [HttpPost]
        public ActionResult<Album> Insert([FromBody]AlbumInsertRequest album)
        {
            return _service.Insert(album);
        }
    }
}
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

        [HttpGet("{id}")]
        public ActionResult<Album>Get(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public ActionResult<Album> Insert([FromBody]AlbumInsertRequest album)
        {
            return _service.Insert(album);
        }

        [HttpPut]
        public ActionResult<Album> Update(int id, AlbumInsertRequest album)
        {
            return _service.Update(id, album);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
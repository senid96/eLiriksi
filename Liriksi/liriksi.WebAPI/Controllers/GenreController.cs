using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using liriksi.Model;
using liriksi.WebAPI.Services;
using liriksi.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace liriksi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService service)
        {
            _genreService = service;
        }

        [HttpGet]
        public ActionResult<List<Genre>> Get(string genre)
        {
            return _genreService.Get(genre);
        }

        [HttpPost]
        public ActionResult<Genre> Insert([FromBody]string genre)
        {          
            return _genreService.Insert(genre);
        }
    }
}
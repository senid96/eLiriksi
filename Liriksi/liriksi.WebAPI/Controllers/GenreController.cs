using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using liriksi.Model;
using liriksi.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace liriksi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly GenreService _genreService;

        public GenreController(GenreService service)
        {
            _genreService = service;
        }

        [HttpGet("{name}")]
        public ActionResult<List<Genre>> GetByName(string name)
        {
            return _genreService.Get(name);
        }
    }
}
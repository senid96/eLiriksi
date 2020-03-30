using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using liriksi.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace liriksi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase
    {
        private readonly IService<T, TSearch> _service;
        public BaseController(IService<T, TSearch> service)
        {
            _service = service;
        }
        //TODO
        /*
         za sad si samo album ovako napravio,jos nije testirano, fale insert itd..
         omoguciti swagger da radi
         minuta videa: 30 min
         */
        [HttpGet]
        public List<T> Get([FromQuery]TSearch search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
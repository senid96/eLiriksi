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
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<UserGetRequest>>Get([FromQuery]UserSearchRequest obj)
        {
            return _service.Get(obj);
        }

        [HttpPost]
        public ActionResult<UserGetRequest>Insert(UserInsertRequest obj)
        {
            return _service.Insert(obj);
        }

        [HttpPatch("ChangeUserStatus")]
        public bool ChangeUserStatus(int id, bool status)
        {
            return _service.ChangeUserStatus(id, status);
        }

    }
}
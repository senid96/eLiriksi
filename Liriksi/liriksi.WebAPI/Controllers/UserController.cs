using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace liriksi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<UserGetRequest>> Get([FromQuery]UserSearchRequest request)
        {
            return _userService.Get(request);
        }

        [HttpGet("{id}")]
        public ActionResult<UserGetRequest> Get(int id)
        {
            return _userService.GetById(id);
        }

        [HttpPost]
        public UserGetRequest Insert(UserInsertRequest userRequst)
        {
            return _userService.Insert(userRequst);
        }

        

    }
}
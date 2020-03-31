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
    public class UserController : CRUDController<User, UserSearchRequest, UserInsertRequest, UserInsertRequest>
    {
        public UserController(ICRUD<User, UserSearchRequest, UserInsertRequest, UserInsertRequest> service) : base(service)
        {
        }
    }
}
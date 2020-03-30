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
    public class AlbumController : BaseController<Album, object> //drugi objekt je search, to nemamo pa stavljamo object
    {
        public AlbumController(IService<Album, object> service) : base(service)
        {
            /*konstruktor ostaje, ali u startup klasi treba staviti 
            implementaciju interface-service */
        }
    }
}
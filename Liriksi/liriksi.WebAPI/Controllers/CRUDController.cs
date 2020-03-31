using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using liriksi.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace liriksi.WebAPI.Controllers
{
    public class CRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        private readonly ICRUD<T, TSearch, TInsert, TUpdate> _service = null;
        public CRUDController(ICRUD<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public T Insert(TInsert request)
        {
            return _service.Insert(request);
        }

        [HttpPut]
        public T Update(int id, [FromBody]TUpdate request)
        {
            return _service.Update(id, request);
        }
    }
}
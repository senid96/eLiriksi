using AutoMapper;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WebAPI.EF;
using liriksi.WebAPI.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public class UserService : CRUDService<User, UserSearchRequest,User, UserInsertRequest, UserInsertRequest>
    {
        //ovdje implementiramo generic sa search objektom
        public UserService(LiriksiContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<User> Get(UserSearchRequest search)
        {
            var query = _context.Set<User>().AsQueryable();

            if (search?.Name != null || search?.Surname != null)
            {
                query = query.Where(x => x.Name.Contains(search.Name) || x.Surname.Contains(search.Surname));
            }
          
            query = query.OrderBy(x => x.Name);

            return query.ToList();
        }
    }
}

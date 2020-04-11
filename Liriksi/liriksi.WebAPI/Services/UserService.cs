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
    public class UserService : IUserService
    {
        private readonly LiriksiContext _context;
        private readonly IMapper _mapper;
        public UserService(LiriksiContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        public List<UserGetRequest> Get(UserSearchRequest obj)
        {
            var query = _context.User.AsQueryable();

            if (!string.IsNullOrEmpty(obj.Name))
                query = query.Where(x => x.Name.Contains(obj.Name));
            if (!string.IsNullOrEmpty(obj.Surname))
                query = query.Where(x => x.Surname.Contains(obj.Surname));

            var result = query.ToList();
            return _mapper.Map<List<UserGetRequest>>(result);
        }

        public UserGetRequest Insert(UserInsertRequest obj)
        {
            var entity = _mapper.Map<User>(obj);
            entity.Salt = "test";
            entity.Hash = "test"; //todo login

            _context.User.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<UserGetRequest>(entity);
        }
    }
}

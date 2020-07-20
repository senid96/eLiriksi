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
using Microsoft.EntityFrameworkCore;

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
        [HttpGet("{id}")]
        public UserGetRequest Get(int id)
        {
            User usr = _context.User.Where(x => x.Id == id)
                                    .Include(b => b.City).Include(b => b.UserType).FirstOrDefault();
            return _mapper.Map<UserGetRequest>(usr);
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

        public UserGetRequest Update(int id, UserInsertRequest obj)
        {
            var entity = _context.User.Find(id);
            if (obj != null)
            {
                entity.Username = obj.Username;
                entity.Name = obj.Name;
                entity.PhoneNumber = obj.PhoneNumber;
                entity.Status = obj.Status;
                entity.Surname = obj.Surname;
                entity.Email = obj.Email;
                _context.SaveChanges();
                return _mapper.Map<UserGetRequest>(entity);
            }
            return null;
        }

        public bool ChangeUserStatus(int id, bool status) //1 active, 0 nonactive
        {
            var usr = _context.User.Find(id);
            if (usr != null)
            {
                _context.User.Attach(usr);
                _context.Update(usr);
                usr.Status = status;

                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<UserType> GetUserTypes()
        {
            return _context.UserType.ToList();
        }
    }
}

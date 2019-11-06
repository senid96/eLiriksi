using AutoMapper;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WebAPI.EF;
using liriksi.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public class UserService: IUserService
    {
        private readonly LiriksiContext _context;
        private readonly IMapper _mapper;
        public UserService(LiriksiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //methods
        public List<UserGetRequest> Get()
        {
            var list = _context.User.ToList();
            return _mapper.Map<List<UserGetRequest>>(list);
        }
        public UserGetRequest GetById(int id)
        {
            var user = _context.User.Where(x => x.Id.Equals(id)).FirstOrDefault();
            return _mapper.Map<UserGetRequest>(user);
        }    
        public UserGetRequest Insert(UserInsertRequest userRequest)
        {
            if(userRequest.Password != userRequest.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slazu!");
            }

            var entity = _mapper.Map<User>(userRequest);
            entity.Hash = "test";
            entity.Salt = "test";

            _context.User.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<UserGetRequest>(entity);
        }
     
    }
}

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
        public List<UserGetRequest> Get(UserSearchRequest request)
        {
            var query = _context.User.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Name))
            { // ? je ako je citav objekat null prestaje izvrsenje koda
                query = query.Where(x => x.Name.Contains(request.Name));
            }

            if (!string.IsNullOrWhiteSpace(request?.Surname))
            { // ? je ako je citav objekat null prestaje izvrsenje koda
                query = query.Where(x => x.Surname.Contains(request.Surname));
            }

            var list = query.ToList();

            return _mapper.Map<List<UserGetRequest>>(list);

        }
        public UserGetRequest GetById(int id)
        {
            var user = _context.User.Find(id);
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
            entity.Status = true;
            _context.User.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<UserGetRequest>(entity);
        }
        public UserGetRequest Update(int id, UserInsertRequest userRequest)
        {
            var entity = _context.User.Find(id);

            if (!string.IsNullOrEmpty(userRequest.Password) && !string.IsNullOrEmpty(userRequest.Password))
            {
                if (!userRequest.Password.Equals(userRequest.PasswordConfirmation))
                {
                    throw new Exception("Passwords are not equal");
                }
                //TODO update password
            }
             
            _context.Attach(entity);
            _context.Update(entity);

           // _mapper.Map<User>(userRequest);
            _mapper.Map(userRequest, entity);
            _context.SaveChanges();

            return _mapper.Map<UserGetRequest>(userRequest);
        }
     
    }
}

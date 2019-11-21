using liriksi.Model;
using liriksi.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public interface IUserService
    {
        List<UserGetRequest> Get(UserSearchRequest request);
        UserGetRequest GetById(int id);
        UserGetRequest Insert(UserInsertRequest userRequest);
        UserGetRequest Update(int id, UserInsertRequest userRequest);

    }
}

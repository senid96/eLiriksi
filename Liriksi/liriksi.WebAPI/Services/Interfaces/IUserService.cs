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
        List<UserGetRequest> Get(UserSearchRequest obj);
        UserGetRequest Insert(UserInsertRequest obj);
        bool ChangeUserStatus(int id, bool status);
    }
}

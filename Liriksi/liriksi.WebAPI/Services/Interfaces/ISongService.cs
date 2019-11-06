using liriksi.Model;
using liriksi.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public interface ISongService
    {
        List<Song> Get();
        Song GetById(int id);
        Song Insert(SongInsertRequest song);
        void Delete(int id);
    }
}

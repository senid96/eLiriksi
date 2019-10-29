using liriksi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public interface ISongService
    {
        IList<Song> Get();
    }
}

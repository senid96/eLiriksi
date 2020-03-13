using liriksi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services.Interfaces
{
    public interface IAlbumService
    {
        List<Album> Get();

        Album Insert(Album album);

    }
}

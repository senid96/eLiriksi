using liriksi.Model;
using liriksi.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services.Interfaces
{
    public interface IAlbumService
    {
        List<Album> Get(string title);
        Album Insert(AlbumInsertRequest album);

    }
}

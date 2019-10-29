using liriksi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public class SongService : ISongService
    {
        public IList<Song> Get()
        {
            List<Song> list = new List<Song>() {
            new Song()
            {
                SongId = 1,
                Name = "Holy Wars",
                Album = "Rust in peace"
            },
            new Song()
            {
                SongId = 2,
                Name = "Hangar 18",
                Album = "Rust in peace"
            }};
            return list;
        }

    }
}

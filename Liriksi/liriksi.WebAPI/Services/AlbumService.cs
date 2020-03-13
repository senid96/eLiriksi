using liriksi.Model;
using liriksi.WebAPI.EF;
using liriksi.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public class AlbumService :IAlbumService
    {
        private readonly LiriksiContext _context;

        public AlbumService(LiriksiContext context)
        {
            _context = context;
        }

        public List<Album> Get()
        {
            return _context.Album.ToList();
        }

        public Album Insert(Album album)
        {
            _context.Album.Add(album);
            _context.SaveChanges();
            return _context.Album.Last();
        }
    }
}

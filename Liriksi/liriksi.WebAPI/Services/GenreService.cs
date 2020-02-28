using liriksi.Model;
using liriksi.WebAPI.EF;
using liriksi.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public class GenreService : IGenreService
    {
        private readonly LiriksiContext _context;
        public GenreService(LiriksiContext context)
        {
            _context = context;
        }

        public List<Genre> Get(string genre)
        {
            var query = _context.Genre.AsQueryable();

            // return query.Where(x => x.Name.Contains(genre)).ToList<Genre>();
            return _context.Genre.ToList<Genre>();

            //return null;
            // return;//TODO, ne radi, ne gadja metodu
        }
    }
}

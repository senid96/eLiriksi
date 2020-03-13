using liriksi.Model;
using liriksi.WebAPI.EF;
using liriksi.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
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
            if (genre==null)
                return query.ToList<Genre>();
            else
                return query.Where(x => x.Name.Contains(genre)).ToList<Genre>();
        }

        public Genre Insert(string genre)
        {
            //var query = _context.Genre.AsQueryable();
            Genre obj = new Genre() { Name = genre };

            _context.Genre.Add(obj);
            _context.SaveChanges();
            return _context.Genre.Last();
        }
    }
}

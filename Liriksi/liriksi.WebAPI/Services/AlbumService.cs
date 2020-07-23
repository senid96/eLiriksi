using AutoMapper;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WebAPI.EF;
using liriksi.WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly LiriksiContext _context;
        private readonly IMapper _mapper;

        public AlbumService(LiriksiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Album> Get(string title)
        {
            if(string.IsNullOrEmpty(title))
                return _context.Album.Include(b=>b.Genre).ToList();
            else
                return _context.Album.Where(x => x.Name.Contains(title)).Include(b => b.Genre).ToList();
        }
        public Album GetById(int id)
        {
            var entity = _context.Album.Find(id);
            if (entity != null)
                return entity;
            else
                return null;
        }
        public Album Insert(AlbumInsertRequest album)
        {
            var entity = _mapper.Map<Album>(album);
            _context.Album.Add(entity);
            _context.SaveChanges();

            return _context.Album.Last(); ;
        }
        public Album Update(int id, AlbumInsertRequest album)
        {
            var entity = _context.Album.Find(id);
            _context.Album.Attach(entity);
            _context.Album.Update(entity);

            entity.Name = album.Name;
            entity.YearRelease = album.YearRelease;
            entity.GenreId = album.GenreId;

            _context.SaveChanges();

            return entity;
        }
        public bool Delete(int id)
        {
            var entity = _context.Album.Find(id);
            if (entity != null)
            {
                _context.Album.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Album> GetAlbumsByPerformerId(int id)
        {
            return _context.Album.Where(x => x.PerformerId == id).ToList();
        }
    }
}

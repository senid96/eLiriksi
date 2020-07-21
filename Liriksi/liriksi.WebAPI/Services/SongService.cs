using AutoMapper;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WebAPI.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public class SongService : ISongService
    {
        //context dependency injection
        private readonly LiriksiContext _context;
        private readonly IMapper _mapper;
        public SongService(LiriksiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
       
        public List<SongGetRequest> Get(SongSearchRequest request)
        {
            var query = _context.Song.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Title))
            {
                query = query.Where(x => x.Title.Contains(request.Title));
            }
            if (!string.IsNullOrWhiteSpace(request?.Text))
            {
                query = query.Where(x => x.Text.Contains(request.Text));
            }
          
            var result = query.ToList();

            return _mapper.Map<List<SongGetRequest>>(result);
        }

        public SongGetRequest GetById(int id)
        {
            var entity = _context.Song.Where(x => x.Id.Equals(id)).FirstOrDefault();
            return _mapper.Map<SongGetRequest>(entity);
        }
        
        public SongGetRequest Insert(SongInsertRequest song)
        {        
            var entity = _mapper.Map<Song>(song);
            _context.Song.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<SongGetRequest>(_context.Song.Last());
        }
        
        public SongGetRequest Update(int id, SongInsertRequest obj)
        {
            var entity = _context.Song.Find(id);
            if (entity != null)
            {
                _context.Song.Attach(entity);
                _context.Song.Update(entity);

                entity.Title = obj.Title;
                entity.Text = obj.Text;
                entity.AlbumId = obj.AlbumId;
                entity.PerformerId = obj.PerformerId;

                _context.SaveChanges();
                return _mapper.Map<SongGetRequest>(entity);
            }
            return null;
        }

        public bool Delete(int id)
        {
            var entity = _context.Song.Find(id);
            if(entity != null)
            {
                _context.Song.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

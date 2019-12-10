using AutoMapper;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WebAPI.EF;
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

        public Song GetById(int id)
        {
            return _context.Song.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
        public Song Insert(SongInsertRequest song)
        {
            var entity = _mapper.Map<Song>(song);
            _context.Song.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Song>(song);
        }
        public void Delete(int id)
        {
            Song s = new Song() { Id = id };
            _context.Remove(s); //todo
        }

    }
}

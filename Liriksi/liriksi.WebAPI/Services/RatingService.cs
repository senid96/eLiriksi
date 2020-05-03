using AutoMapper;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.Model.Requests.rates;
using liriksi.WebAPI.EF;
using liriksi.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public class RatingService : IRatingService
    {
        private readonly LiriksiContext _context;
        private readonly IMapper _mapper;
        public RatingService(LiriksiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool RateAlbum(UsersAlbumRate obj)
        {
            var entity = _context.UsersAlbumRates.Find(obj.AlbumId, obj.UserId);

            if (entity != null)
            {
                if (entity.AlbumId.Equals(obj.AlbumId) && entity.UserId.Equals(obj.UserId))
                    return false;
            }
            _context.UsersAlbumRates.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool RateSong(UsersSongRate obj)
        {
            var entity = _context.UsersSongRates.Find(obj.UserId, obj.SongId);

            if (entity != null)
            {
                if (entity.SongId.Equals(obj.SongId) && entity.UserId.Equals(obj.UserId))
                    return false;
            }
            _context.UsersSongRates.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public List<UsersAlbumRateRequest> GetAlbumRates()
        {
            var entity = (from rates in _context.UsersAlbumRates
                              join album in _context.Album on rates.AlbumId equals album.Id
                              join user in _context.User on rates.UserId equals user.Id
                              select new
                              {
                                  AlbumId = album.Id,
                                  AlbumTitle = album.Name,
                                  UserId = rates.UserId,
                                  Username = user.Username,
                                  Rate = rates.Rate,
                                  Comment = rates.Comment
                              });
            return _mapper.Map<List<UsersAlbumRateRequest>>(entity);

        }

        public List<UsersSongRateRequest> GetSongRates()
        {
            var entity = (from rates in _context.UsersSongRates
                          join song in _context.Song on rates.SongId equals song.Id
                          join user in _context.User on rates.UserId equals user.Id
                          select new
                          {
                              SongId = song.Id,
                              SongTitle = song.Title,
                              UserId = rates.UserId,
                              Username = user.Username,
                              Rate = rates.Rate,
                              Comment = rates.Comment
                          });
            return _mapper.Map<List<UsersSongRateRequest>>(entity);
        }
    }
}

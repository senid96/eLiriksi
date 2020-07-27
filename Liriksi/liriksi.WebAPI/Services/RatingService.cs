using AutoMapper;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.Model.Requests.rates;
using liriksi.WebAPI.EF;
using liriksi.WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Xml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

        public List<UsersAlbumRateGetRequest> GetRatesByAlbum(int albumId)
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
                              Comment = rates.Comment,
                          }).Where(x=>x.AlbumId == albumId);
            return _mapper.Map<List<UsersAlbumRateGetRequest>>(entity);

        }

        public List<UsersSongRateGetRequest> GetRatesBySong(int songId)
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
                              Comment = rates.Comment,
                          }).Where(x=>x.SongId == songId);
            return _mapper.Map<List<UsersSongRateGetRequest>>(entity);
        }

        //get all albums and their average rate
        public List<AverageRate> GetAlbumRates()
        {
            List<AverageRate> list = _context.UsersAlbumRates
                 .Join(_context.Album,
                 rate => rate.AlbumId,
                 album => album.Id,
                 (rate, album) => new
                 {
                     album.Name,
                     rate.Rate,
                     rate.AlbumId
                 })
                 .GroupBy(p => p.AlbumId)
                 .Select(g => new AverageRate { Id = g.First().AlbumId, Title = g.First().Name,  AvgRate = Math.Round( Convert.ToDouble(g.Sum(x => x.Rate)) / g.Count(), 1) }).ToList();

            return list;
        }

        //get all songs and their average rate
        public List<AverageRate> GetSongRates()
        {
            List<AverageRate> list = _context.UsersSongRates
                .Join(_context.Song,
                rate => rate.SongId,
                song => song.Id,
                (rate, song) => new 
                {
                    song.Title,
                    rate.Rate,
                    rate.SongId
                })
                .GroupBy(p => p.SongId)
                .Select(g => new AverageRate{ Id = g.First().SongId, Title = g.First().Title , AvgRate = Math.Round(Convert.ToDouble(g.Sum(x => x.Rate)) / g.Count(), 1) }).ToList();

            return list;
        }

        public List<UsersSongRateGetRequest> GetSongRatesByUser(int userId)
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
                              Comment = rates.Comment,
                          }).Where(x => x.UserId == userId);
            return _mapper.Map<List<UsersSongRateGetRequest>>(entity);
        }

        public List<UsersAlbumRateGetRequest> GetAlbumRatesByUser(int userId)
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
                              Comment = rates.Comment,
                          }).Where(x => x.UserId == userId);
            return _mapper.Map<List<UsersAlbumRateGetRequest>>(entity);
        }

    }
}


using AutoMapper;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WebAPI.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


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
          
            var result = query.Include(x=>x.Album).Include(x=>x.Album.Performer).Take(10).ToList();

            return _mapper.Map<List<SongGetRequest>>(result);
        }

        public SongGetRequest GetById(int id)
        {
            var entity = _context.Song.Where(x => x.Id.Equals(id)).Include(b=>b.Album.Genre).Include(b=>b.UsersSongRates).FirstOrDefault();
            return _mapper.Map<SongGetRequest>(entity);
        }

        public List<SongGetRequest> GetSongsByAlbum(int id)
        {
            List<Song> songs =  _context.Song.Where(x => x.AlbumId.Equals(id)).Include(b=>b.Album).Include(b=>b.Album.Genre).Include(b=>b.Album.Performer).ToList();
            return _mapper.Map<List<SongGetRequest>>(songs);
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


        /* recommender */
       
        Dictionary<int, List<UsersSongRate>> songs = new Dictionary<int, List<UsersSongRate>>();

        public List<SongGetRequest> GetSimilarSongs(int songId)
        {
            LoadSongs(songId);
            List<UsersSongRate> ratesOfObservedSong = _context.UsersSongRates.Where(x => x.SongId == songId).OrderBy(x => x.UserId).ToList();

            List<UsersSongRate> commonRates1 = new List<UsersSongRate>();
            List<UsersSongRate> commonRates2 = new List<UsersSongRate>();
            List<SongGetRequest> recommendedSongs = new List<SongGetRequest>();

            foreach (var item in songs)
            {
                foreach (UsersSongRate r in ratesOfObservedSong)
                {
                    if (item.Value.Where(x => x.UserId == r.UserId).Count() > 0)
                    {
                        commonRates1.Add(r);
                        commonRates2.Add(item.Value.Where(x => x.UserId == r.UserId).First());
                    }
                }
                double similarity = GetSimilarity(commonRates1, commonRates2);

                if (similarity > 0.5)
                    recommendedSongs.Add(_mapper.Map<SongGetRequest>(_context.Song.Where(x => x.Id == item.Key).FirstOrDefault()));

                commonRates1.Clear();
                commonRates2.Clear();
            }

            return recommendedSongs;
        }

        private double GetSimilarity(List<UsersSongRate> commonRates1, List<UsersSongRate> commonRates2)
        {
            if (commonRates1.Count != commonRates2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < commonRates1.Count; i++)
            {
                brojnik = commonRates1[i].Rate * commonRates2[i].Rate;
                nazivnik1 = commonRates1[i].Rate * commonRates1[i].Rate;
                nazivnik2 = commonRates2[i].Rate * commonRates2[i].Rate;
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);

            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;

            return brojnik / nazivnik;
        }

        private void LoadSongs(int songId)
        {
            List<Song> allSongs = _context.Song.Where(x => x.Id != songId).ToList(); //sve osim posmatrane pjesme, tj te referentne
            List<UsersSongRate> rates;
            foreach (Song item in allSongs)
            {
                rates = _context.UsersSongRates.Where(x => x.SongId == item.Id).OrderBy(x => x.UserId).ToList();
                if (rates.Count > 0)
                {
                    songs.Add(item.Id, rates);
                }
            }
        }
    }
}

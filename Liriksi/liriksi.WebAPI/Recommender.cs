using AutoMapper;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WebAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI
{
    public class Recommender
    {
        private readonly LiriksiContext db;
        private readonly IMapper _mapper;


        Dictionary<int, List<UsersSongRate>> songs = new Dictionary<int, List<UsersSongRate>>();

        public List<SongGetRequest> GetSimilarSongs(int songId)
        {
            LoadSongs(songId);
            List<UsersSongRate> ratesOfObservedSong = db.UsersSongRates.Where(x => x.SongId == songId).OrderBy(x => x.UserId).ToList();

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
                    recommendedSongs.Add(_mapper.Map<SongGetRequest>(db.Song.Where(x => x.Id == item.Key).FirstOrDefault()));

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
            List<Song> allSongs = db.Song.Where(x => x.Id != songId).ToList(); //sve osim posmatrane pjesme, tj te referentne
            List<UsersSongRate> rates;
            foreach (Song item in allSongs)
            {
                rates = db.UsersSongRates.Where(x => x.SongId == item.Id).OrderBy(x => x.UserId).ToList();
                if (rates.Count > 0)
                {
                    songs.Add(item.Id, rates);
                }
            }
        }
    }
}

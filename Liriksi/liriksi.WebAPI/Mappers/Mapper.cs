using AutoMapper;
using liriksi.Model;
using liriksi.Model.Requests;

namespace liriksi.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            //user
            CreateMap<User, UserGetRequest>().ReverseMap();
            CreateMap<User, UserInsertRequest>().ReverseMap();
            CreateMap<UserInsertRequest, UserGetRequest>().ReverseMap();
            CreateMap<User, UserSearchRequest>().ReverseMap();
          
            //song
            CreateMap<Song, SongInsertRequest > ().ReverseMap();
            //CreateMap<Song, SongGetRequest>().ReverseMap(); todo obrisati 'song get request'

            //album
            CreateMap<Album, AlbumInsertRequest>().ReverseMap();

            //performer
            CreateMap<Performer, PerformerInsertRequest>().ReverseMap();
        }
    }
}

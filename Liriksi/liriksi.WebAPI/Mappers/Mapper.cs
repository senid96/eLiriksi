using AutoMapper;
using liriksi.Model;
using liriksi.Model.Requests;

namespace liriksi.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<User, UserGetRequest>().ReverseMap();
            CreateMap<User, UserInsertRequest>().ReverseMap();
            CreateMap<UserInsertRequest, UserGetRequest>().ReverseMap();
            CreateMap<SongInsertRequest, Song>().ReverseMap();
        }
    }
}

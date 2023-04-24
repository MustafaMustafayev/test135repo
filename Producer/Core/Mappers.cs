using AutoMapper;
using Producer.DTOs;
using Producer.Entities;

namespace Producer.Core
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<UserToAddDto, User>();
            CreateMap<UserToUpdateDto, User>();
            CreateMap<User, UserToListDto>();
        }
    }
}

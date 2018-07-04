using AutoMapper;
using GamesPortal.BL.DTOs;
using GamesPortal.DAL.Entities;

namespace GamesPortal.BL.Resources.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(m => m.Id, c => c.MapFrom(d => d.Id))
                .ForMember(m => m.FirstName, c => c.MapFrom(d => d.FirstName))
                .ForMember(m => m.LastName, c => c.MapFrom(d => d.LastName))
                .ForMember(m => m.UserName, c => c.MapFrom(d => d.UserName))
                .ForMember(m => m.PassWord, c => c.MapFrom(d => d.PassWord))
                .ForMember(m => m.Email, c => c.MapFrom(d => d.Email))
                .ForAllOtherMembers(m => m.Ignore());
            CreateMap<UserDto, User>()
                .ForMember(m => m.Id, c => c.MapFrom(d => d.Id))
                .ForMember(m => m.FirstName, c => c.MapFrom(d => d.FirstName))
                .ForMember(m => m.LastName, c => c.MapFrom(d => d.LastName))
                .ForMember(m => m.UserName, c => c.MapFrom(d => d.UserName))
                .ForMember(m => m.PassWord, c => c.MapFrom(d => d.PassWord))
                .ForMember(m => m.Email, c => c.MapFrom(d => d.Email))
                .ForAllOtherMembers(m => m.Ignore());
        }
    }
}

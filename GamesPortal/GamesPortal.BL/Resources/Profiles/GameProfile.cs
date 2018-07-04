using AutoMapper;
using GamesPortal.BL.DTOs;
using GamesPortal.DAL.Entities;

namespace GamesPortal.BL.Resources.Profiles
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            CreateMap<Game, GameDto>()
                .ForMember(m => m.Id, c => c.MapFrom(d => d.Id))
                .ForMember(m => m.Name, c => c.MapFrom(d => d.Name))
                .ForAllOtherMembers(m => m.Ignore());
            CreateMap<GameDto, Game>()
                .ForMember(m => m.Id, c => c.MapFrom(d => d.Id))
                .ForMember(m => m.Name, c => c.MapFrom(d => d.Name))
                .ForAllOtherMembers(m => m.Ignore());
        }
    }
}

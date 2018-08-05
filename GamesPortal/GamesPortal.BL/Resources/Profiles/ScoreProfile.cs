using AutoMapper;
using GamesPortal.BL.DTOs;
using GamesPortal.DAL.Entities;

namespace GamesPortal.BL.Resources.Profiles
{
    public class ScoreProfile : Profile
    {
        public ScoreProfile()
        {
            CreateMap<Score, ScoreDto>()
                .ForMember(m => m.Id, c => c.MapFrom(d => d.Id))
                .ForMember(m => m.GameId, c => c.MapFrom(d => d.GameId))
                .ForMember(m => m.UserId, c => c.MapFrom(d => d.UserId))
                .ForMember(m => m.Amount, c => c.MapFrom(d => d.Amount))
                .ForAllOtherMembers(m => m.Ignore());
            CreateMap<ScoreDto, Score>()
                .ForMember(m => m.Id, c => c.MapFrom(d => d.Id))
                .ForMember(m => m.GameId, c => c.MapFrom(d => d.GameId))
                .ForMember(m => m.UserId, c => c.MapFrom(d => d.UserId))
                .ForMember(m => m.Amount, c => c.MapFrom(d => d.Amount))
                .ForAllOtherMembers(m => m.Ignore());
        }
    }
}

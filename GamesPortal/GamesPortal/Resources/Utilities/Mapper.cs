using AutoMapper;
using GamesPortal.BL.Resources.Profiles;

namespace GamesPortal.Api.Resources.Utilities
{
    public class Mapper
    {
        public static IMapper Instance;

        static Mapper()
        {
            var mapperConfiguration = new MapperConfiguration(config =>
            {
                config.AddProfile<UserProfile>();
                config.AddProfile<GameProfile>();
                config.AddProfile<ScoreProfile>();
            });

            Instance = mapperConfiguration.CreateMapper();
        }
    }
}

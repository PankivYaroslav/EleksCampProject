using System.Collections.Generic;

namespace GamesPortal.DAL.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Score> Scores { get; set; }
    }
}

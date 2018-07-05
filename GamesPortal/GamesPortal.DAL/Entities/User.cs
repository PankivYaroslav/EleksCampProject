using System.Collections.Generic;

namespace GamesPortal.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }

        public ICollection<Score> Scores { get; set; }
    }
}

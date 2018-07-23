using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace GamesPortal.DAL.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassWord { get; set; }
        
        public ICollection<Score> Scores { get; set; }
    }
}

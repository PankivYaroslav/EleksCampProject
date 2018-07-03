namespace GamesPortal.DAL.Entities
{
    public class Score
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public long Amount { get; set; }
    }
}

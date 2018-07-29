namespace GamesPortal.DAL.Entities
{
    public class Score
    {
        public int Id { get; set; }
		public int GameId { get; set; }
        public string UserId { get; set; }
        public long Amount { get; set; }

        public Game Game { get; set; }
        public User User { get; set; }
    }
}

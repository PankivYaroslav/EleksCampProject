namespace GamesPortal.BL.DTOs
{
    public class ScoreDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public long Amount { get; set; }
    }
}

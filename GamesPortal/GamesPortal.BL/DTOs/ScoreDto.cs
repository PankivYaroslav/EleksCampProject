namespace GamesPortal.BL.DTOs
{
    public class ScoreDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int GameId { get; set; }
        public long Amount { get; set; }
    }
}

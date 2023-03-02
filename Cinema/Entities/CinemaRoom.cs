namespace CinemaApp.Entities
{
    public class CinemaRoom
    {
        public int Id { get; set; }
        public CinemaRoomType CinemaRoomType { get; set; }
        public decimal Price { get; set; }
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
        public HashSet<Film> films { get; set; }
    }
}

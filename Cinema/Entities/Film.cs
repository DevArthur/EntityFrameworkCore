using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool InBillboard { get; set; }
        public DateTime ReleaseDate { get; set; }
        //[Unicode(false)]
        public string  PosterURL { get; set; }
    }
}

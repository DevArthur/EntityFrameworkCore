using NetTopologySuite.Geometries;

namespace CinemaApp.Entities
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //[Precision(precision:9, scale: 2)], configured in API Fluent.
        //public decimal Price { get; set; }
        public Point Ubication { get; set; }
        public CinemaOffer CinemaOffer { get; set; }

        //The difference between HashSet and ICollection is that HashSet is faster
        //than ICollection but HashSet does not sort the data.
        //public ICollection<CinemaRoom> CinemaRooms { get; set; }
        public HashSet<CinemaRoom> CinemaRooms { get; set; }
    }
}

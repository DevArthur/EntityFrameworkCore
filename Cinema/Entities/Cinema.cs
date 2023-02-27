using NetTopologySuite.Geometries;

namespace CinemaApp.Entities
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //[Precision(precision:9, scale: 2)], configured in API Fluent.
        public decimal Price { get; set; }
        public Point Ubication { get; set; }
    }
}

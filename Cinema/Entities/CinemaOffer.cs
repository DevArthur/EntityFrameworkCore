namespace CinemaApp.Entities
{
    public class CinemaOffer
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public decimal DiscountRate { get; set; }
        public int CinemaId { get; set; }
    }
}

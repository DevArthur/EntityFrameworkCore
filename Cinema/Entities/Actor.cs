using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaApp.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        //To change the type in the database from datetime2 wich is the one 
        //that is mapping from DateTime .NET to datetime:
        //[Column(TypeName ="Date")]
        public DateTime BirthDate { get; set; }
        public HashSet<FilmActor> FilmActors { get; set; }
    }
}

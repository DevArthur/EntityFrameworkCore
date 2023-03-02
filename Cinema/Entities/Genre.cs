using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaApp.Entities
{
    //[Table("GenreTable", Schema ="movies")] -> Rename table name from
    // Genre to GenreTable in the database.
    public class Genre
    {
        //NOTE: Check ApplicationDbContext class to know how
        //to do the configurations with with Fluent API

        //With data annotations: 
        //[Key]
        public int Id { get; set; }
        // With data annotations
        //[Key] -> PK
        //[StringLength(150)] -> size
        //[MaxLength(150)] -> size
        //[Required] -> not nullable
        //[Column(name:"GenreName")] -> change column name from Name to 
                                     // GenreName in the database
        public string Name { get; set; }
        public HashSet<Film> Films { get; set; }
    }
}

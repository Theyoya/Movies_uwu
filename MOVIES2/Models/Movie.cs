using System.ComponentModel.DataAnnotations;

namespace MOVIES2.Models
{
    public class Movie
    {
    
        public int id { get; set; }
        [Display(Name = "titulo")]

        public string? Title { get; set; }
        [DataType(DataType.Date)]

        [Display(Name = "Fecha de Liberacion")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Genero")]
        public string? Genre { get; set; }
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
    }

}

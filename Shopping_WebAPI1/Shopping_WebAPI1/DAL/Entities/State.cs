using System.ComponentModel.DataAnnotations;

namespace Shopping_WebAPI1.Entities
{
    public class State : Entity
    {
        [Display(Name = "País")] 
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] //Longitud màxima (NVARCHAR(50))
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Name { get; set; }

        [Display(Name = "País")]
        public Country Country { get; set; }

        [Display(Name = "Id País")]
        public Guid CountryId { get; set; }

        [Display(Name = "Ciudades")]
        public ICollection<City> Cities { get; set; } //Esto significa que un estado puede tener N Ciudades    

        //Propiedad de Lectura que no se mapea en la tabla de la DB
        public int CitiesNumber => Cities == null ? 0 : Cities.Count; // If Ternario (? Entonces), (: sino)
    }
}

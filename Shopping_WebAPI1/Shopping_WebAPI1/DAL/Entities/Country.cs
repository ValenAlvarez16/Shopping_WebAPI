using System.ComponentModel.DataAnnotations;

namespace Shopping_WebAPI1.Entities
{
    public class Country : Entity
    {
        [Display(Name = "País")]//mostrar el name con otro nombre
        [MaxLength(50,ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]//LONGITUD MÁXIMA (NVARCHAR(50))
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]//NOT NULL
        public string Name { get; set; }
    }
}

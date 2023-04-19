using System.ComponentModel.DataAnnotations;

namespace Shopping_WebAPI1.Entities
{
    public class Category : Entity
    {
        [Display(Name = "Categoría")]//mostrar el name con otro nombre
        [MaxLength(50,ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]//LONGITUD MÁXIMA (NVARCHAR(100))
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]//NOT NULL

        public string Name { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]

        public string? Description { get; set; }
    }
}

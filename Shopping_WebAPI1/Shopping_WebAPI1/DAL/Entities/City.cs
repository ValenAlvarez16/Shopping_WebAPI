﻿using System.ComponentModel.DataAnnotations;

namespace Shopping_WebAPI1.Entities
{
    public class City : Entity
    {
        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] //Longitud màxima (NVARCHAR(50))
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Name { get; set; }

        [Display(Name = "Estado")]
        public State State { get; set; }

        //FK
        [Required]
        public Guid StateId { get; set; }
    }

}
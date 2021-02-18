using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BibliotecaSystem.Models
{
    public class Libros : EntityBase
    {
        [Required(ErrorMessage = "El campo Título del libro no puede estar vacío")]
        [MinLength(2)]
        [MaxLength(10)]
        [Display(Name = "Titulo del libro")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El campo Categoría no puede estar vacío")]
        [MinLength(20)]
        [MaxLength(60)]
        [Display(Name = "Categoría")]
        public string Categoria { get; set; }

        public string Autor { get; set; }

        public int Existencias { get; set; }
    }
}

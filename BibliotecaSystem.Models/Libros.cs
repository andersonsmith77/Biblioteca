using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaSystem.Models
{
    public class Libros : EntityBase
    {
        public string Titulo { get; set; }

        public string Categoria { get; set; }

        public string Autor { get; set; }

        public int Existencias { get; set; }
    }
}

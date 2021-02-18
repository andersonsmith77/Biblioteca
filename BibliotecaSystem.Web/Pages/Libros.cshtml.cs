using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaSystem.Data.Interfaces;
using BibliotecaSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BibliotecaSystem.Web.Pages
{
    public class LibrosModel : PageModel
    {
        private readonly ILibroRepository _libroRepository;

        public LibrosModel(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }

        [BindProperty]
        public IEnumerable<Libros> Libro { get; set; }

        public IActionResult OnGet()
        {
            Libro = _libroRepository.List();
            return Page();
        }
    }
}

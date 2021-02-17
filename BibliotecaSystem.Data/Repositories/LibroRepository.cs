using BibliotecaSystem.Data.Interfaces;
using BibliotecaSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaSystem.Data.Repositories
{
    public class LibroRepository : Repository<Libros>, ILibroRepository
    {
        private readonly ApplicationDbContext _db;
        public LibroRepository(ApplicationDbContext db): base(db)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMELY_APRAEZ_EXAMEN_CSHARP_2025
{
    internal class BibliotecaDigital
    {
        private List<Libro> Libros { get; set; }
        private List<Usuario> Usuarios { get; set; }
        private List<Prestamo> Prestamos { get; set; }
        private int UltimoIdUsuario { get; set; }
        private int UltimoIdPrestamo { get; set; }

        public BibliotecaDigital()
        {
            Libros = new List<Libro>();
            Usuarios = new List<Usuario>();
            Prestamos = new List<Prestamo>();
            UltimoIdUsuario = 0;
            UltimoIdPrestamo = 0;
        }

        public void PrecargarDatos()
        {
            // Precargar libros
            List<Libro> librosPreCargados = new List<Libro>
            {
                new Libro { Titulo = "Cien años de soledad", Autor = "Gabriel García Márquez", AnioPublicacion = 1967, ISBN = "9780307350427", Disponible = true },
                new Libro { Titulo = "1984", Autor = "George Orwell", AnioPublicacion = 1949, ISBN = "9788499890944", Disponible = true },
                new Libro { Titulo = "Don Quijote de la Mancha", Autor = "Miguel de Cervantes", AnioPublicacion = 1605, ISBN = "9788420412146", Disponible = true },
                new Libro { Titulo = "Harry Potter y la piedra filosofal", Autor = "J.K. Rowling", AnioPublicacion = 1997, ISBN = "9788478886456", Disponible = true },
                new Libro { Titulo = "El señor de los anillos", Autor = "J.R.R. Tolkien", AnioPublicacion = 1954, ISBN = "9788445071403", Disponible = true },
                new Libro { Titulo = "El principito", Autor = "Antoine de Saint-Exupéry", AnioPublicacion = 1943, ISBN = "9788478886296", Disponible = true },
                new Libro { Titulo = "El código Da Vinci", Autor = "Dan Brown", AnioPublicacion = 2003, ISBN = "9780307474278", Disponible = true },
                new Libro { Titulo = "Crónica de una muerte anunciada", Autor = "Gabriel García Márquez", AnioPublicacion = 1981, ISBN = "9780307474278", Disponible = true }
            };
            Libros.AddRange(librosPreCargados);

            // Precargar usuarios
            List<Usuario> usuariosPreCargados = new List<Usuario>
            {
                new Usuario { Id = ++UltimoIdUsuario, Nombre = "Ana García", CorreoElectronico = "ana.garcia@email.com", Telefono = "12345678" },
                new Usuario { Id = ++UltimoIdUsuario, Nombre = "Carlos Rodríguez", CorreoElectronico = "carlos.rodriguez@email.com", Telefono = "87654321" },
                new Usuario { Id = ++UltimoIdUsuario, Nombre = "María López", CorreoElectronico = "maria.lopez@email.com", Telefono = "56781234" }
            };
            Usuarios.AddRange(usuariosPreCargados);

            // Precargar algunos préstamos
            List<Prestamo> prestamosPreCargados = new List<Prestamo>
            {
                new Prestamo
                {
                    Id = ++UltimoIdPrestamo,
                    IdUsuario = 1,
                    ISBN = "9788420412146",
                    FechaPrestamo = DateTime.Now.AddDays(-20),
                    FechaDevolucionEsperada = DateTime.Now.AddDays(-6),
                    FechaDevolucionReal = DateTime.Now.AddDays(-8),
                    Estado = EstadoPrestamo.Finalizado
                },
                new Prestamo
                {
                    Id = ++UltimoIdPrestamo,
                    IdUsuario = 2,
                    ISBN = "9788478886456",
                    FechaPrestamo = DateTime.Now.AddDays(-10),
                    FechaDevolucionEsperada = DateTime.Now.AddDays(4),
                    FechaDevolucionReal = null,
                    Estado = EstadoPrestamo.Activo
                },
                new Prestamo
                {
                    Id = ++UltimoIdPrestamo,
                    IdUsuario = 3,
                    ISBN = "9780307350427",
                    FechaPrestamo = DateTime.Now.AddDays(-30),
                    FechaDevolucionEsperada = DateTime.Now.AddDays(-16),
                    FechaDevolucionReal = null,
                    Estado = EstadoPrestamo.Activo
                }
            };
            Prestamos.AddRange(prestamosPreCargados);

            // Actualizar disponibilidad de los libros prestados
            foreach (Prestamo prestamo in Prestamos.Where(p => p.Estado == EstadoPrestamo.Activo))
            {
                Libro libro = BuscarLibroPorISBN(prestamo.ISBN);
                if (libro != null)
                {
                    libro.Disponible = false;
                }
            }
        }

        #region Gestión de Libros
        public void AgregarLibro(Libro libro)
        {
            if (ExisteISBN(libro.ISBN))
            {
                throw new InvalidOperationException("Ya existe un libro con ese ISBN.");
            }

            Libros.Add(libro);
        }

        public List<Libro> ObtenerTodosLosLibros()
        {
            return Libros.OrderBy(l => l.Titulo).ToList();
        }

        public bool ExisteISBN(string isbn)
        {
            return Libros.Any(l => l.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));
        }

        public Libro BuscarLibroPorISBN(string isbn)
        {
            return Libros.FirstOrDefault(l => l.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));
        }

        public List<Libro> BuscarLibrosPorTitulo(string titulo)
        {
            return Libros
                .Where(l => l.Titulo.IndexOf(titulo, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(l => l.Titulo)
                .ToList();
        }

        public List<Libro> BuscarLibrosPorAutor(string autor)
        {
            return Libros
                .Where(l => l.Autor.IndexOf(autor, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(l => l.Autor)
                .ThenBy(l => l.Titulo)
                .ToList();
        }
        #endregion

        #region Gestión de Usuarios
        public int GenerarNuevoIdUsuario()
        {
            return ++UltimoIdUsuario;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            if (ExisteCorreoUsuario(usuario.CorreoElectronico))
            {
                throw new InvalidOperationException("Ya existe un usuario con ese correo electrónico.");
            }

            Usuarios.Add(usuario);
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            return Usuarios.OrderBy(u => u.Nombre).ToList();
        }

        public bool ExisteCorreoUsuario(string correo)
        {
            return Usuarios.Any(u => u.CorreoElectronico.Equals(correo, StringComparison.OrdinalIgnoreCase));
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            return Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public Usuario BuscarUsuarioPorCorreo(string correo)
        {
            return Usuarios.FirstOrDefault(u => u.CorreoElectronico.Equals(correo, StringComparison.OrdinalIgnoreCase));
        }

        public List<Usuario> BuscarUsuariosPorNombre(string nombre)
        {
            return Usuarios
                .Where(u => u.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(u => u.Nombre)
                .ToList();
        }
        #endregion

        #region Gestión de Préstamos
        public int GenerarNuevoIdPrestamo()
        {
            return ++UltimoIdPrestamo;
        }

        public void RegistrarPrestamo(Prestamo prestamo)
        {
            // Validar que el usuario exista
            Usuario usuario = BuscarUsuarioPorId(prestamo.IdUsuario);
            if (usuario == null)
            {
                throw new InvalidOperationException("El usuario no existe.");
            }

            // Validar que el libro exista
            Libro libro = BuscarLibroPorISBN(prestamo.ISBN);
            if (libro == null)
            {
                throw new InvalidOperationException("El libro no existe.");
            }

            // Validar que el libro esté disponible
            if (!libro.Disponible)
            {
                throw new InvalidOperationException("El libro no está disponible.");
            }

            // Validar que el usuario no tenga 3 o más préstamos activos
            int prestamosActivos = ContarPrestamosActivosPorUsuario(prestamo.IdUsuario);
            if (prestamosActivos >= 3)
            {
                throw new InvalidOperationException("El usuario ya tiene 3 préstamos activos (máximo permitido).");
            }

            // Registrar el préstamo
            Prestamos.Add(prestamo);

            // Actualizar el estado del libro
            libro.Disponible = false;
        }

        public void RegistrarDevolucion(int idPrestamo, DateTime fechaDevolucion)
        {
            Prestamo prestamo = BuscarPrestamoPorId(idPrestamo);
            if (prestamo == null)
            {
                throw new InvalidOperationException("El préstamo no existe.");
            }

            if (prestamo.Estado != EstadoPrestamo.Activo)
            {
                throw new InvalidOperationException("El préstamo ya ha sido finalizado.");
            }

            // Actualizar el préstamo
            prestamo.FechaDevolucionReal = fechaDevolucion;
            prestamo.Estado = EstadoPrestamo.Finalizado;

            // Actualizar el estado del libro
            Libro libro = BuscarLibroPorISBN(prestamo.ISBN);
            if (libro != null)
            {
                libro.Disponible = true;
            }
        }

        public Prestamo BuscarPrestamoPorId(int id)
        {
            return Prestamos.FirstOrDefault(p => p.Id == id);
        }

        public int ContarPrestamosActivosPorUsuario(int idUsuario)
        {
            return Prestamos.Count(p => p.IdUsuario == idUsuario && p.Estado == EstadoPrestamo.Activo);
        }

        public List<Prestamo> ObtenerPrestamosActivos()
        {
            return Prestamos
                .Where(p => p.Estado == EstadoPrestamo.Activo)
                .OrderBy(p => p.FechaDevolucionEsperada)
                .ToList();
        }

        public List<Prestamo> ObtenerPrestamosPorUsuario(int idUsuario)
        {
            return Prestamos
                .Where(p => p.IdUsuario == idUsuario)
                .OrderByDescending(p => p.FechaPrestamo)
                .ToList();
        }

        public List<Prestamo> ObtenerPrestamosAtrasados()
        {
            return Prestamos
                .Where(p => p.Estado == EstadoPrestamo.Activo && p.FechaDevolucionEsperada < DateTime.Now)
                .OrderBy(p => p.FechaDevolucionEsperada)
                .ToList();
        }

        public List<(Libro, int)> ObtenerLibrosMasPrestados()
        {
            return Prestamos
                .GroupBy(p => p.ISBN)
                .Select(g => (BuscarLibroPorISBN(g.Key), g.Count()))
                .Where(t => t.Item1 != null)
                .OrderByDescending(t => t.Item2)
                .ToList();
        }

        public List<(Usuario, int, int, int)> ObtenerUsuariosConMasPrestamos()
        {
            return Prestamos
                .GroupBy(p => p.IdUsuario)
                .Select(g => (
                    BuscarUsuarioPorId(g.Key),
                    g.Count(),
                    g.Count(p => p.Estado == EstadoPrestamo.Activo),
                    g.Count(p => p.Estado == EstadoPrestamo.Finalizado)))
                .Where(t => t.Item1 != null)
                .OrderByDescending(t => t.Item2)
                .ToList();
        }

        #endregion
    }
}

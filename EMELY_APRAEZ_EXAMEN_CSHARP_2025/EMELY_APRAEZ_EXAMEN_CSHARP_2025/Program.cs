using EMELY_APRAEZ_EXAMEN_CSHARP_2025;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program
{

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        BibliotecaDigital biblioteca = new BibliotecaDigital();

        biblioteca.PrecargarDatos();

        MenuPrincipal(biblioteca);
    }


    static void MenuPrincipal(BibliotecaDigital biblioteca)
    {
        bool salir = false;

        while (!salir)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE GESTIÓN DE BIBLIOTECA DIGITAL ===");
                Console.WriteLine("1. Gestión de Libros");
                Console.WriteLine("2. Gestión de Usuarios");
                Console.WriteLine("3. Gestión de Préstamos");
                Console.WriteLine("4. Reportes");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MenuLibros(biblioteca);
                        break;
                    case "2":
                        MenuUsuarios(biblioteca);
                        break;
                    case "3":
                        MenuPrestamos(biblioteca);
                        break;
                    case "4":
                        MenuReportes(biblioteca);
                        break;
                    case "0":
                        salir = true;
                        break;
                    default:
                        MostrarMensaje("Opción no válida. Intente nuevamente.", ConsoleColor.Red);
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error inesperado: {ex.Message}", ConsoleColor.Red);
            }
        }
    }

    static void MenuLibros(BibliotecaDigital biblioteca)
    {
        bool volver = false;

        while (!volver)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== GESTIÓN DE LIBROS ===");
                Console.WriteLine("1. Registrar nuevo libro");
                Console.WriteLine("2. Buscar libros");
                Console.WriteLine("3. Actualizar información de libro");
                Console.WriteLine("4. Ver todos los libros");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarLibro(biblioteca);
                        break;
                    case "2":
                        BuscarLibros(biblioteca);
                        break;
                    case "3":
                        ActualizarLibro(biblioteca);
                        break;
                    case "4":
                        MostrarTodosLosLibros(biblioteca);
                        break;
                    case "0":
                        volver = true;
                        break;
                    default:
                        MostrarMensaje("Opción no válida. Intente nuevamente.", ConsoleColor.Red);
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error inesperado: {ex.Message}", ConsoleColor.Red);
            }
        }
    }

    static void MenuUsuarios(BibliotecaDigital biblioteca)
    {
        bool volver = false;

        while (!volver)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== GESTIÓN DE USUARIOS ===");
                Console.WriteLine("1. Registrar nuevo usuario");
                Console.WriteLine("2. Buscar usuarios");
                Console.WriteLine("3. Actualizar información de usuario");
                Console.WriteLine("4. Ver todos los usuarios");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarUsuario(biblioteca);
                        break;
                    case "2":
                        BuscarUsuarios(biblioteca);
                        break;
                    case "3":
                        ActualizarUsuario(biblioteca);
                        break;
                    case "4":
                        MostrarTodosLosUsuarios(biblioteca);
                        break;
                    case "0":
                        volver = true;
                        break;
                    default:
                        MostrarMensaje("Opción no válida. Intente nuevamente.", ConsoleColor.Red);
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error inesperado: {ex.Message}", ConsoleColor.Red);
            }
        }
    }

    static void MenuPrestamos(BibliotecaDigital biblioteca)
    {
        bool volver = false;

        while (!volver)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== GESTIÓN DE PRÉSTAMOS ===");
                Console.WriteLine("1. Registrar nuevo préstamo");
                Console.WriteLine("2. Registrar devolución");
                Console.WriteLine("3. Ver préstamos activos");
                Console.WriteLine("4. Ver préstamos por usuario");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarPrestamo(biblioteca);
                        break;
                    case "2":
                        RegistrarDevolucion(biblioteca);
                        break;
                    case "3":
                        MostrarPrestamosActivos(biblioteca);
                        break;
                    case "4":
                        MostrarPrestamosPorUsuario(biblioteca);
                        break;
                    case "0":
                        volver = true;
                        break;
                    default:
                        MostrarMensaje("Opción no válida. Intente nuevamente.", ConsoleColor.Red);
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error inesperado: {ex.Message}", ConsoleColor.Red);
            }
        }
    }

    static void MenuReportes(BibliotecaDigital biblioteca)
    {
        bool volver = false;

        while (!volver)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== REPORTES ===");
                Console.WriteLine("1. Libros más prestados");
                Console.WriteLine("2. Libros atrasados en devolución");
                Console.WriteLine("3. Usuarios con más préstamos");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ReporteLibrosMasPrestados(biblioteca);
                        break;
                    case "2":
                        ReporteLibrosAtrasados(biblioteca);
                        break;
                    case "3":
                        ReporteUsuariosConMasPrestamos(biblioteca);
                        break;
                    case "0":
                        volver = true;
                        break;
                    default:
                        MostrarMensaje("Opción no válida. Intente nuevamente.", ConsoleColor.Red);
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error inesperado: {ex.Message}", ConsoleColor.Red);
            }
        }
    }


    #region Gestión de Libros
    static void RegistrarLibro(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== REGISTRAR NUEVO LIBRO ===");

        try
        {
            string titulo = SolicitarEntrada("Título", true);
            string autor = SolicitarEntrada("Autor", true);

            int anioPublicacion = 0;
            bool anioValido = false;
            while (!anioValido)
            {
                try
                {
                    string anioStr = SolicitarEntrada("Año de publicación", true);
                    anioPublicacion = int.Parse(anioStr);

                    if (anioPublicacion <= 0 || anioPublicacion > DateTime.Now.Year)
                    {
                        Console.WriteLine($"El año debe ser un número positivo y no mayor al año actual ({DateTime.Now.Year}).");
                    }
                    else
                    {
                        anioValido = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, ingrese un número válido para el año.");
                }
            }

            string isbn = string.Empty;
            bool isbnValido = false;
            while (!isbnValido)
            {
                isbn = SolicitarEntrada("ISBN", true);
                if (biblioteca.ExisteISBN(isbn))
                {
                    Console.WriteLine("El ISBN ya existe en el sistema. Por favor, ingrese un ISBN único.");
                }
                else
                {
                    isbnValido = true;
                }
            }

            Libro nuevoLibro = new Libro
            {
                Titulo = titulo,
                Autor = autor,
                AnioPublicacion = anioPublicacion,
                ISBN = isbn,
                Disponible = true
            };

            biblioteca.AgregarLibro(nuevoLibro);
            MostrarMensaje($"Libro '{titulo}' registrado correctamente.", ConsoleColor.Green);
        }
        catch (Exception ex)
        {
            MostrarMensaje($"Error al registrar el libro: {ex.Message}", ConsoleColor.Red);
        }
    }

    static void BuscarLibros(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== BUSCAR LIBROS ===");
        Console.WriteLine("1. Buscar por título");
        Console.WriteLine("2. Buscar por autor");
        Console.WriteLine("3. Buscar por ISBN");
        Console.WriteLine("0. Volver");
        Console.Write("\nSeleccione una opción: ");

        string opcion = Console.ReadLine();

        List<Libro> resultados = new List<Libro>();

        switch (opcion)
        {
            case "1":
                string titulo = SolicitarEntrada("Título (o parte del título)", true);
                resultados = biblioteca.BuscarLibrosPorTitulo(titulo);
                break;
            case "2":
                string autor = SolicitarEntrada("Autor (o parte del nombre)", true);
                resultados = biblioteca.BuscarLibrosPorAutor(autor);
                break;
            case "3":
                string isbn = SolicitarEntrada("ISBN", true);
                Libro? libro = biblioteca.BuscarLibroPorISBN(isbn);
                if (libro != null)
                {
                    resultados.Add(libro);
                }
                break;
            case "0":
                return;
            default:
                MostrarMensaje("Opción no válida.", ConsoleColor.Red);
                return;
        }

        if (resultados.Count > 0)
        {
            Console.WriteLine("\nResultados de la búsqueda:");
            MostrarLibros(resultados);
        }
        else
        {
            MostrarMensaje("No se encontraron libros con los criterios de búsqueda.", ConsoleColor.Yellow);
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ActualizarLibro(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== ACTUALIZAR INFORMACIÓN DE LIBRO ===");

        try
        {
            string isbn = SolicitarEntrada("Ingrese el ISBN del libro a actualizar", true);
            Libro? libro = biblioteca.BuscarLibroPorISBN(isbn);

            if (libro == null)
            {
                MostrarMensaje("No se encontró un libro con ese ISBN.", ConsoleColor.Red);
                return;
            }

            Console.WriteLine($"\nInformación actual del libro:");
            Console.WriteLine($"Título: {libro.Titulo}");
            Console.WriteLine($"Autor: {libro.Autor}");
            Console.WriteLine($"Año de publicación: {libro.AnioPublicacion}");
            Console.WriteLine($"ISBN: {libro.ISBN}");
            Console.WriteLine($"Disponible: {(libro.Disponible ? "Sí" : "No")}");

            Console.WriteLine("\n¿Qué desea actualizar?");
            Console.WriteLine("1. Título");
            Console.WriteLine("2. Autor");
            Console.WriteLine("3. Año de publicación");
            Console.WriteLine("0. Cancelar");
            Console.Write("\nSeleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    string nuevoTitulo = SolicitarEntrada("Nuevo título", true);
                    libro.Titulo = nuevoTitulo;
                    MostrarMensaje("Título actualizado correctamente.", ConsoleColor.Green);
                    break;
                case "2":
                    string nuevoAutor = SolicitarEntrada("Nuevo autor", true);
                    libro.Autor = nuevoAutor;
                    MostrarMensaje("Autor actualizado correctamente.", ConsoleColor.Green);
                    break;
                case "3":
                    int nuevoAnio = 0;
                    bool anioValido = false;
                    while (!anioValido)
                    {
                        try
                        {
                            string anioStr = SolicitarEntrada("Nuevo año de publicación", true);
                            nuevoAnio = int.Parse(anioStr);

                            if (nuevoAnio <= 0 || nuevoAnio > DateTime.Now.Year)
                            {
                                Console.WriteLine($"El año debe ser un número positivo y no mayor al año actual ({DateTime.Now.Year}).");
                            }
                            else
                            {
                                anioValido = true;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Por favor, ingrese un número válido para el año.");
                        }
                    }

                    libro.AnioPublicacion = nuevoAnio;
                    MostrarMensaje("Año de publicación actualizado correctamente.", ConsoleColor.Green);
                    break;
                case "0":
                    MostrarMensaje("Operación cancelada.", ConsoleColor.Yellow);
                    break;
                default:
                    MostrarMensaje("Opción no válida.", ConsoleColor.Red);
                    break;
            }
        }
        catch (Exception ex)
        {
            MostrarMensaje($"Error al actualizar el libro: {ex.Message}", ConsoleColor.Red);
        }
    }

    static void MostrarTodosLosLibros(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== CATÁLOGO COMPLETO DE LIBROS ===");

        List<Libro> libros = biblioteca.ObtenerTodosLosLibros();

        if (libros.Count > 0)
        {
            MostrarLibros(libros);
        }
        else
        {
            MostrarMensaje("No hay libros registrados en el sistema.", ConsoleColor.Yellow);
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void MostrarLibros(List<Libro> libros)
    {
        Console.WriteLine("\n{0,-40} {1,-30} {2,-10} {3,-15} {4,-15}", "TÍTULO", "AUTOR", "AÑO", "ISBN", "DISPONIBLE");
        Console.WriteLine(new string('-', 115));

        foreach (Libro libro in libros)
        {
            Console.WriteLine("{0,-40} {1,-30} {2,-10} {3,-15} {4,-15}",
                libro.Titulo.Length > 37 ? libro.Titulo.Substring(0, 37) + "..." : libro.Titulo,
                libro.Autor.Length > 27 ? libro.Autor.Substring(0, 27) + "..." : libro.Autor,
                libro.AnioPublicacion,
                libro.ISBN,
                libro.Disponible ? "Sí" : "No");
        }
    }
    #endregion


    #region Gestión de Usuarios
    static void RegistrarUsuario(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== REGISTRAR NUEVO USUARIO ===");

        try
        {
            string nombre = SolicitarEntrada("Nombre completo", true);

            string correo = string.Empty;
            bool correoValido = false;
            while (!correoValido)
            {
                correo = SolicitarEntrada("Correo electrónico", true);
                if (!EsCorreoValido(correo))
                {
                    Console.WriteLine("El formato del correo electrónico no es válido. Ejemplo: usuario@dominio.com");
                }
                else if (biblioteca.ExisteCorreoUsuario(correo))
                {
                    Console.WriteLine("Ya existe un usuario con ese correo electrónico.");
                }
                else
                {
                    correoValido = true;
                }
            }

            string telefono = string.Empty;
            bool telefonoValido = false;
            while (!telefonoValido)
            {
                telefono = SolicitarEntrada("Teléfono", true);
                if (!EsTelefonoValido(telefono))
                {
                    Console.WriteLine("El formato del teléfono no es válido. Debe contener solo números y tener al menos 8 dígitos.");
                }
                else
                {
                    telefonoValido = true;
                }
            }

            Usuario nuevoUsuario = new Usuario
            {
                Id = biblioteca.GenerarNuevoIdUsuario(),
                Nombre = nombre,
                CorreoElectronico = correo,
                Telefono = telefono
            };

            biblioteca.AgregarUsuario(nuevoUsuario);
            MostrarMensaje($"Usuario '{nombre}' registrado correctamente con ID: {nuevoUsuario.Id}.", ConsoleColor.Green);
        }
        catch (Exception ex)
        {
            MostrarMensaje($"Error al registrar el usuario: {ex.Message}", ConsoleColor.Red);
        }
    }

    static void BuscarUsuarios(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== BUSCAR USUARIOS ===");
        Console.WriteLine("1. Buscar por ID");
        Console.WriteLine("2. Buscar por nombre");
        Console.WriteLine("3. Buscar por correo electrónico");
        Console.WriteLine("0. Volver");
        Console.Write("\nSeleccione una opción: ");

        string opcion = Console.ReadLine();

        List<Usuario> resultados = new List<Usuario>();

        switch (opcion)
        {
            case "1":
                try
                {
                    int id = 0;
                    bool idValido = false;
                    while (!idValido)
                    {
                        try
                        {
                            string idStr = SolicitarEntrada("ID de usuario", true);
                            id = int.Parse(idStr);

                            if (id <= 0)
                            {
                                Console.WriteLine("El ID debe ser un número positivo.");
                            }
                            else
                            {
                                idValido = true;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Por favor, ingrese un número válido para el ID.");
                        }
                    }

                    Usuario usuario = biblioteca.BuscarUsuarioPorId(id);
                    if (usuario != null)
                    {
                        resultados.Add(usuario);
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensaje($"Error: {ex.Message}", ConsoleColor.Red);
                    return;
                }
                break;
            case "2":
                string nombre = SolicitarEntrada("Nombre (o parte del nombre)", true);
                resultados = biblioteca.BuscarUsuariosPorNombre(nombre);
                break;
            case "3":
                string correo = SolicitarEntrada("Correo electrónico", true);
                Usuario usuarioPorCorreo = biblioteca.BuscarUsuarioPorCorreo(correo);
                if (usuarioPorCorreo != null)
                {
                    resultados.Add(usuarioPorCorreo);
                }
                break;
            case "0":
                return;
            default:
                MostrarMensaje("Opción no válida.", ConsoleColor.Red);
                return;
        }

        if (resultados.Count > 0)
        {
            Console.WriteLine("\nResultados de la búsqueda:");
            MostrarUsuarios(resultados);
        }
        else
        {
            MostrarMensaje("No se encontraron usuarios con los criterios de búsqueda.", ConsoleColor.Yellow);
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ActualizarUsuario(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== ACTUALIZAR INFORMACIÓN DE USUARIO ===");

        try
        {
            int id = 0;
            bool idValido = false;
            while (!idValido)
            {
                try
                {
                    string idStr = SolicitarEntrada("Ingrese el ID del usuario a actualizar", true);
                    id = int.Parse(idStr);

                    if (id <= 0)
                    {
                        Console.WriteLine("El ID debe ser un número positivo.");
                    }
                    else
                    {
                        idValido = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, ingrese un número válido para el ID.");
                }
            }

            Usuario? usuario = biblioteca.BuscarUsuarioPorId(id);

            if (usuario == null)
            {
                MostrarMensaje("No se encontró un usuario con ese ID.", ConsoleColor.Red);
                return;
            }

            Console.WriteLine($"\nInformación actual del usuario:");
            Console.WriteLine($"ID: {usuario.Id}");
            Console.WriteLine($"Nombre: {usuario.Nombre}");
            Console.WriteLine($"Correo electrónico: {usuario.CorreoElectronico}");
            Console.WriteLine($"Teléfono: {usuario.Telefono}");

            Console.WriteLine("\n¿Qué desea actualizar?");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Correo electrónico");
            Console.WriteLine("3. Teléfono");
            Console.WriteLine("0. Cancelar");
            Console.Write("\nSeleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    string nuevoNombre = SolicitarEntrada("Nuevo nombre", true);
                    usuario.Nombre = nuevoNombre;
                    MostrarMensaje("Nombre actualizado correctamente.", ConsoleColor.Green);
                    break;
                case "2":
                    string nuevoCorreo = string.Empty;
                    bool correoValido = false;
                    while (!correoValido)
                    {
                        nuevoCorreo = SolicitarEntrada("Nuevo correo electrónico", true);
                        if (!EsCorreoValido(nuevoCorreo))
                        {
                            Console.WriteLine("El formato del correo electrónico no es válido. Ejemplo: usuario@dominio.com");
                        }
                        else if (biblioteca.ExisteCorreoUsuario(nuevoCorreo) && nuevoCorreo != usuario.CorreoElectronico)
                        {
                            Console.WriteLine("Ya existe otro usuario con ese correo electrónico.");
                        }
                        else
                        {
                            correoValido = true;
                        }
                    }

                    usuario.CorreoElectronico = nuevoCorreo;
                    MostrarMensaje("Correo electrónico actualizado correctamente.", ConsoleColor.Green);
                    break;
                case "3":
                    string nuevoTelefono = string.Empty;
                    bool telefonoValido = false;
                    while (!telefonoValido)
                    {
                        nuevoTelefono = SolicitarEntrada("Nuevo teléfono", true);
                        if (!EsTelefonoValido(nuevoTelefono))
                        {
                            Console.WriteLine("El formato del teléfono no es válido. Debe contener solo números y tener al menos 8 dígitos.");
                        }
                        else
                        {
                            telefonoValido = true;
                        }
                    }

                    usuario.Telefono = nuevoTelefono;
                    MostrarMensaje("Teléfono actualizado correctamente.", ConsoleColor.Green);
                    break;
                case "0":
                    MostrarMensaje("Operación cancelada.", ConsoleColor.Yellow);
                    break;
                default:
                    MostrarMensaje("Opción no válida.", ConsoleColor.Red);
                    break;
            }
        }
        catch (Exception ex)
        {
            MostrarMensaje($"Error al actualizar el usuario: {ex.Message}", ConsoleColor.Red);
        }
    }

    static void MostrarTodosLosUsuarios(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== LISTADO COMPLETO DE USUARIOS ===");

        List<Usuario> usuarios = biblioteca.ObtenerTodosLosUsuarios();

        if (usuarios.Count > 0)
        {
            MostrarUsuarios(usuarios);
        }
        else
        {
            MostrarMensaje("No hay usuarios registrados en el sistema.", ConsoleColor.Yellow);
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void MostrarUsuarios(List<Usuario> usuarios)
    {
        Console.WriteLine("\n{0,-5} {1,-30} {2,-30} {3,-15}", "ID", "NOMBRE", "CORREO ELECTRÓNICO", "TELÉFONO");
        Console.WriteLine(new string('-', 85));

        foreach (Usuario usuario in usuarios)
        {
            Console.WriteLine("{0,-5} {1,-30} {2,-30} {3,-15}",
                usuario.Id,
                usuario.Nombre.Length > 27 ? usuario.Nombre.Substring(0, 27) + "..." : usuario.Nombre,
                usuario.CorreoElectronico.Length > 27 ? usuario.CorreoElectronico.Substring(0, 27) + "..." : usuario.CorreoElectronico,
                usuario.Telefono);
        }
    }
    #endregion


    #region Gestión de Préstamos
    static void RegistrarPrestamo(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== REGISTRAR NUEVO PRÉSTAMO ===");

        try
        {
            int idUsuario = 0;
            bool idUsuarioValido = false;

            while (!idUsuarioValido)
            {
                try
                {
                    string idStr = SolicitarEntrada("ID del usuario", true);
                    idUsuario = int.Parse(idStr);

                    if (idUsuario <= 0)
                    {
                        Console.WriteLine("El ID del usuario debe ser un número positivo.");
                    }
                    else
                    {
                        Usuario usuario = biblioteca.BuscarUsuarioPorId(idUsuario);
                        if (usuario == null)
                        {
                            Console.WriteLine("No existe un usuario con ese ID.");
                        }
                        else
                        {
                            // Verificar si el usuario tiene 3 o más préstamos activos
                            int prestamosActivos = biblioteca.ContarPrestamosActivosPorUsuario(idUsuario);
                            if (prestamosActivos >= 3)
                            {
                                Console.WriteLine($"El usuario {usuario.Nombre} ya tiene {prestamosActivos} préstamos activos (máximo permitido: 3).");
                            }
                            else
                            {
                                Console.WriteLine($"Usuario: {usuario.Nombre}");
                                idUsuarioValido = true;
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, ingrese un número válido para el ID.");
                }
            }

            string isbn = string.Empty;
            bool isbnValido = false;

            while (!isbnValido)
            {
                isbn = SolicitarEntrada("ISBN del libro", true);
                Libro libro = biblioteca.BuscarLibroPorISBN(isbn);

                if (libro == null)
                {
                    Console.WriteLine("No existe un libro con ese ISBN.");
                }
                else if (!libro.Disponible)
                {
                    Console.WriteLine($"El libro '{libro.Titulo}' no está disponible actualmente.");
                }
                else
                {
                    Console.WriteLine($"Libro: {libro.Titulo} - {libro.Autor}");
                    isbnValido = true;
                }
            }

            // Calcular fechas
            DateTime fechaPrestamo = DateTime.Now;
            DateTime fechaDevolucionEsperada = fechaPrestamo.AddDays(14);

            // Crear el préstamo
            Prestamo nuevoPrestamo = new Prestamo
            {
                Id = biblioteca.GenerarNuevoIdPrestamo(),
                IdUsuario = idUsuario,
                ISBN = isbn,
                FechaPrestamo = fechaPrestamo,
                FechaDevolucionEsperada = fechaDevolucionEsperada,
                FechaDevolucionReal = null,
                Estado = EstadoPrestamo.Activo
            };

            // Registrar el préstamo y actualizar el estado del libro
            biblioteca.RegistrarPrestamo(nuevoPrestamo);

            Console.WriteLine("\nResumen del préstamo:");
            Console.WriteLine($"ID de préstamo: {nuevoPrestamo.Id}");
            Console.WriteLine($"Usuario: {biblioteca.BuscarUsuarioPorId(idUsuario).Nombre}");
            Console.WriteLine($"Libro: {biblioteca.BuscarLibroPorISBN(isbn).Titulo}");
            Console.WriteLine($"Fecha de préstamo: {fechaPrestamo.ToString("dd/MM/yyyy HH:mm")}");
            Console.WriteLine($"Fecha de devolución esperada: {fechaDevolucionEsperada.ToString("dd/MM/yyyy")}");

            MostrarMensaje("\nPréstamo registrado correctamente.", ConsoleColor.Green);
        }
        catch (Exception ex)
        {
            MostrarMensaje($"Error al registrar el préstamo: {ex.Message}", ConsoleColor.Red);
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void RegistrarDevolucion(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== REGISTRAR DEVOLUCIÓN ===");

        try
        {
            int idPrestamo = 0;
            bool idPrestamoValido = false;

            while (!idPrestamoValido)
            {
                try
                {
                    string idStr = SolicitarEntrada("ID del préstamo", true);
                    idPrestamo = int.Parse(idStr);

                    if (idPrestamo <= 0)
                    {
                        Console.WriteLine("El ID del préstamo debe ser un número positivo.");
                    }
                    else
                    {
                        Prestamo prestamo = biblioteca.BuscarPrestamoPorId(idPrestamo);
                        if (prestamo == null)
                        {
                            Console.WriteLine("No existe un préstamo con ese ID.");
                        }
                        else if (prestamo.Estado != EstadoPrestamo.Activo)
                        {
                            Console.WriteLine("Este préstamo ya ha sido finalizado.");
                        }
                        else
                        {
                            Usuario usuario = biblioteca.BuscarUsuarioPorId(prestamo.IdUsuario);
                            Libro libro = biblioteca.BuscarLibroPorISBN(prestamo.ISBN);

                            Console.WriteLine("\nDetalles del préstamo:");
                            Console.WriteLine($"ID: {prestamo.Id}");
                            Console.WriteLine($"Usuario: {usuario.Nombre}");
                            Console.WriteLine($"Libro: {libro.Titulo}");
                            Console.WriteLine($"Fecha de préstamo: {prestamo.FechaPrestamo.ToString("dd/MM/yyyy HH:mm")}");
                            Console.WriteLine($"Fecha de devolución esperada: {prestamo.FechaDevolucionEsperada.ToString("dd/MM/yyyy")}");

                            idPrestamoValido = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, ingrese un número válido para el ID.");
                }
            }

            // Confirmar devolución
            Console.WriteLine("\n¿Desea registrar la devolución? (S/N): ");
            string confirmacion = Console.ReadLine().Trim().ToUpper();

            if (confirmacion == "S")
            {
                DateTime fechaDevolucion = DateTime.Now;
                biblioteca.RegistrarDevolucion(idPrestamo, fechaDevolucion);

                Prestamo prestamo = biblioteca.BuscarPrestamoPorId(idPrestamo);

                bool estaAtrasado = prestamo.FechaDevolucionEsperada < fechaDevolucion;

                if (estaAtrasado)
                {
                    TimeSpan retraso = fechaDevolucion - prestamo.FechaDevolucionEsperada;
                    MostrarMensaje($"\nDevolución registrada con retraso de {retraso.Days} día(s).", ConsoleColor.Yellow);
                }
                else
                {
                    MostrarMensaje("\nDevolución registrada correctamente.", ConsoleColor.Green);
                }
            }
            else
            {
                MostrarMensaje("\nOperación cancelada.", ConsoleColor.Yellow);
            }
        }
        catch (Exception ex)
        {
            MostrarMensaje($"Error al registrar la devolución: {ex.Message}", ConsoleColor.Red);
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void MostrarPrestamosActivos(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== PRÉSTAMOS ACTIVOS ===");

        List<Prestamo> prestamos = biblioteca.ObtenerPrestamosActivos();

        if (prestamos.Count > 0)
        {
            MostrarPrestamos(prestamos, biblioteca);
        }
        else
        {
            MostrarMensaje("No hay préstamos activos en el sistema.", ConsoleColor.Yellow);
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void MostrarPrestamosPorUsuario(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== PRÉSTAMOS POR USUARIO ===");

        try
        {
            int idUsuario = 0;
            bool idUsuarioValido = false;

            while (!idUsuarioValido)
            {
                try
                {
                    string idStr = SolicitarEntrada("ID del usuario", true);
                    idUsuario = int.Parse(idStr);

                    if (idUsuario <= 0)
                    {
                        Console.WriteLine("El ID del usuario debe ser un número positivo.");
                    }
                    else
                    {
                        Usuario usuario = biblioteca.BuscarUsuarioPorId(idUsuario);
                        if (usuario == null)
                        {
                            Console.WriteLine("No existe un usuario con ese ID.");
                        }
                        else
                        {
                            Console.WriteLine($"\nHistorial de préstamos para {usuario.Nombre}:");
                            idUsuarioValido = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, ingrese un número válido para el ID.");
                }
            }

            List<Prestamo> prestamos = biblioteca.ObtenerPrestamosPorUsuario(idUsuario);

            if (prestamos.Count > 0)
            {
                MostrarPrestamos(prestamos, biblioteca);
            }
            else
            {
                MostrarMensaje("Este usuario no tiene préstamos registrados.", ConsoleColor.Yellow);
            }
        }
        catch (Exception ex)
        {
            MostrarMensaje($"Error: {ex.Message}", ConsoleColor.Red);
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void MostrarPrestamos(List<Prestamo> prestamos, BibliotecaDigital biblioteca)
    {
        Console.WriteLine("\n{0,-5} {1,-20} {2,-40} {3,-15} {4,-15} {5,-15}", "ID", "USUARIO", "LIBRO", "PRESTADO", "DEVOLUCIÓN", "ESTADO");
        Console.WriteLine(new string('-', 115));

        foreach (Prestamo prestamo in prestamos)
        {
            Usuario usuario = biblioteca.BuscarUsuarioPorId(prestamo.IdUsuario);
            Libro libro = biblioteca.BuscarLibroPorISBN(prestamo.ISBN);

            string estadoPrestamo;
            ConsoleColor colorEstado = ConsoleColor.Gray;

            if (prestamo.Estado == EstadoPrestamo.Finalizado)
            {
                estadoPrestamo = "Devuelto";
                colorEstado = ConsoleColor.Green;
            }
            else if (DateTime.Now > prestamo.FechaDevolucionEsperada)
            {
                estadoPrestamo = "Atrasado";
                colorEstado = ConsoleColor.Red;
            }
            else
            {
                estadoPrestamo = "Activo";
                colorEstado = ConsoleColor.Cyan;
            }

            Console.Write("{0,-5} {1,-20} {2,-40} {3,-15} {4,-15} ",
                prestamo.Id,
                usuario.Nombre.Length > 17 ? usuario.Nombre.Substring(0, 17) + "..." : usuario.Nombre,
                libro.Titulo.Length > 37 ? libro.Titulo.Substring(0, 37) + "..." : libro.Titulo,
                prestamo.FechaPrestamo.ToString("dd/MM/yyyy"),
                prestamo.FechaDevolucionEsperada.ToString("dd/MM/yyyy"));

            ConsoleColor colorOriginal = Console.ForegroundColor;
            Console.ForegroundColor = colorEstado;
            Console.WriteLine(estadoPrestamo);
            Console.ForegroundColor = colorOriginal;
        }
    }
    #endregion


    #region Reportes
    static void ReporteLibrosMasPrestados(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== REPORTE DE LIBROS MÁS PRESTADOS ===");

        try
        {
            List<(Libro, int)> librosMasPrestados = biblioteca.ObtenerLibrosMasPrestados();

            if (librosMasPrestados.Count > 0)
            {
                Console.WriteLine("\n{0,-5} {1,-40} {2,-30} {3,-10} {4,-15}", "#", "TÍTULO", "AUTOR", "AÑO", "PRÉSTAMOS");
                Console.WriteLine(new string('-', 105));

                int posicion = 1;
                foreach ((Libro, int) item in librosMasPrestados)
                {
                    Libro libro = item.Item1;
                    int cantidadPrestamos = item.Item2;

                    Console.WriteLine("{0,-5} {1,-40} {2,-30} {3,-10} {4,-15}",
                        posicion++,
                        libro.Titulo.Length > 37 ? libro.Titulo.Substring(0, 37) + "..." : libro.Titulo,
                        libro.Autor.Length > 27 ? libro.Autor.Substring(0, 27) + "..." : libro.Autor,
                        libro.AnioPublicacion,
                        cantidadPrestamos);
                }
            }
            else
            {
                MostrarMensaje("No hay préstamos registrados en el sistema.", ConsoleColor.Yellow);
            }
        }
        catch (Exception ex)
        {
            MostrarMensaje($"Error: {ex.Message}", ConsoleColor.Red);
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ReporteLibrosAtrasados(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== REPORTE DE LIBROS ATRASADOS EN DEVOLUCIÓN ===");

        try
        {
            List<Prestamo> prestamosAtrasados = biblioteca.ObtenerPrestamosAtrasados();

            if (prestamosAtrasados.Count > 0)
            {
                Console.WriteLine("\n{0,-5} {1,-20} {2,-40} {3,-15} {4,-15} {5,-10}", "ID", "USUARIO", "LIBRO", "PRESTADO", "VENCIMIENTO", "DÍAS ATRASO");
                Console.WriteLine(new string('-', 110));

                foreach (Prestamo prestamo in prestamosAtrasados)
                {
                    Usuario usuario = biblioteca.BuscarUsuarioPorId(prestamo.IdUsuario);
                    Libro libro = biblioteca.BuscarLibroPorISBN(prestamo.ISBN);

                    TimeSpan retraso = DateTime.Now - prestamo.FechaDevolucionEsperada;

                    Console.WriteLine("{0,-5} {1,-20} {2,-40} {3,-15} {4,-15} {5,-10}",
                        prestamo.Id,
                        usuario.Nombre.Length > 17 ? usuario.Nombre.Substring(0, 17) + "..." : usuario.Nombre,
                        libro.Titulo.Length > 37 ? libro.Titulo.Substring(0, 37) + "..." : libro.Titulo,
                        prestamo.FechaPrestamo.ToString("dd/MM/yyyy"),
                        prestamo.FechaDevolucionEsperada.ToString("dd/MM/yyyy"),
                        retraso.Days);
                }
            }
            else
            {
                MostrarMensaje("No hay préstamos atrasados en el sistema.", ConsoleColor.Green);
            }
        }
        catch (Exception ex)
        {
            MostrarMensaje($"Error: {ex.Message}", ConsoleColor.Red);
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ReporteUsuariosConMasPrestamos(BibliotecaDigital biblioteca)
    {
        Console.Clear();
        Console.WriteLine("=== REPORTE DE USUARIOS CON MÁS PRÉSTAMOS ===");

        try
        {
            List<(Usuario, int, int, int)> usuariosConMasPrestamos = biblioteca.ObtenerUsuariosConMasPrestamos();

            if (usuariosConMasPrestamos.Count > 0)
            {
                Console.WriteLine("\n{0,-5} {1,-5} {2,-30} {3,-15} {4,-15} {5,-15}", "#", "ID", "NOMBRE", "PRÉSTAMOS TOTAL", "ACTIVOS", "FINALIZADOS");
                Console.WriteLine(new string('-', 95));

                int posicion = 1;
                foreach ((Usuario, int, int, int) item in usuariosConMasPrestamos)
                {
                    Usuario usuario = item.Item1;
                    int prestamosTotal = item.Item2;
                    int prestamosActivos = item.Item3;
                    int prestamosFinalizados = item.Item4;

                    Console.WriteLine("{0,-5} {1,-5} {2,-30} {3,-15} {4,-15} {5,-15}",
                        posicion++,
                        usuario.Id,
                        usuario.Nombre.Length > 27 ? usuario.Nombre.Substring(0, 27) + "..." : usuario.Nombre,
                        prestamosTotal,
                        prestamosActivos,
                        prestamosFinalizados);
                }
            }
            else
            {
                MostrarMensaje("No hay préstamos registrados en el sistema.", ConsoleColor.Yellow);
            }
        }
        catch (Exception ex)
        {
            MostrarMensaje($"Error: {ex.Message}", ConsoleColor.Red);
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
    #endregion


    #region Utilidades
    static string SolicitarEntrada(string mensaje, bool obligatorio)
    {
        string entrada = string.Empty;
        bool entradaValida = false;

        while (!entradaValida)
        {
            Console.Write($"{mensaje}: ");
            entrada = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(entrada) && obligatorio)
            {
                Console.WriteLine($"El campo {mensaje} es obligatorio. Por favor, ingréselo nuevamente.");
            }
            else
            {
                entradaValida = true;
            }
        }

        return entrada;
    }

    static bool EsCorreoValido(string correo)
    {
        if (string.IsNullOrWhiteSpace(correo))
            return false;

        try
        {
            // Expresión regular para validar formato de correo básico
            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(correo);
        }
        catch
        {
            return false;
        }
    }

    static bool EsTelefonoValido(string telefono)
    {
        if (string.IsNullOrWhiteSpace(telefono))
            return false;

        try
        {
            // Validar que solo contenga números y tenga al menos 8 dígitos
            Regex regex = new Regex(@"^\d{8,}$");
            return regex.IsMatch(telefono);
        }
        catch
        {
            return false;
        }
    }

    static void MostrarMensaje(string mensaje, ConsoleColor color)
    {
        ConsoleColor colorOriginal = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(mensaje);
        Console.ForegroundColor = colorOriginal;

        // Pequeña pausa para que el usuario pueda leer el mensaje
        System.Threading.Thread.Sleep(1500);
    }
    #endregion

}


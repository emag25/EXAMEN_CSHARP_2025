using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMELY_APRAEZ_EXAMEN_CSHARP_2025
{
    internal class Prestamo
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string ISBN { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucionEsperada { get; set; }
        public DateTime? FechaDevolucionReal { get; set; }
        public EstadoPrestamo Estado { get; set; }
    }

    enum EstadoPrestamo
    {
        Activo,
        Finalizado
    }

}

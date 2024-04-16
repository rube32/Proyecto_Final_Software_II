using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final_Software_II.Modelos
{
    public class Pago
    {
        {
    public int Id { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        // Otras propiedades necesarias...
    }

    // Student.cs
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        // Otras propiedades necesarias...
    }
}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final_Software_II
{
    public class pagos
    {
        // Clase para representar un Pago
        public class Payment
        {
            public int IdPago { get; set; }
            public int IdEstidiante { get; set; }
            public decimal Cantidad { get; set; }
            public DateTime Fecha_de_pago
            { get; set; }
        }
    }
}
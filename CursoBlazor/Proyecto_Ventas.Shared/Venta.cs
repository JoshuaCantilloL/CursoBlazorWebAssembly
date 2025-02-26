using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ventas.Shared
{
    public class Venta
    {
        public int IdVenta  {get;set;}
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string NombreCliente { get; set; } = string.Empty;
        public double? Precio { get; set; }
        public double? DineroRecibido { get; set; }
        public double? Cambio { get; set; }
        public int Transferencia { get; set; } = 0;
        


    }
}

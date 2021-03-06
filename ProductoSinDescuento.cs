using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_Carrito
{
    public class ProductoSinDescuento : Producto
    {
        public ProductoSinDescuento()
        {

        }

        public DateTime FechaInicioDescuento { get; set; }

        //Se sobre escribe el metodo calcular descuento
        // y se implementa una funcionalidad en la clase hija
        public decimal CalcularDescuento()
        {
            return 100;
        }

        
        public int CalcularFechaDescuiento()
        {
            TimeSpan timespan = DateTime.Today - this.FechaInicioDescuento;
            int dia = timespan.Days;
            int fecha = dia / 365;
            return fecha;
        }
    }
}

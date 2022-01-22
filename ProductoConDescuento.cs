using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_Carrito
{
    public class ProductoConDescuento : Producto
    {
        public ProductoConDescuento()
        {

        }

        public decimal Descuento { get; set; }

        //Se sobre escribe el metodo calcular descuento
        // y se implementa una funcionalidad en la clase hija
        public decimal CalcularDescuento()
        {
            return this.Precio * (this.Descuento / 100);
        }

    }
}

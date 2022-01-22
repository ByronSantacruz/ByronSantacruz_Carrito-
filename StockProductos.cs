using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_Carrito
{
    public class StockProductos
    {
        public StockProductos()
        {
            this.ListaStockProductos = new List<Producto>();
        }

        public List<Producto> ListaStockProductos { get; set; }

        public void CrearProductos()
        {
            Random random = new Random();
            int numero;
            for (int i = 1; i <= 10; i++)
            {

                Producto producto = new Producto();
                producto.Identificador = i;
                numero = random.Next(20);
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "PRODUCTO" + letra + numero + i;
                producto.Precio = numero;
                this.ListaStockProductos.Add(producto);
            }
        }

        public void ImprimirStockProductos()
        {
            Console.WriteLine("Stock de Productos");
            Console.WriteLine("Identificador\tDescripción\tPrecio");

            foreach (var item in this.ListaStockProductos)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}",
                item.Identificador, item.Descripcion, item.Precio);
            }

        }
    }
}



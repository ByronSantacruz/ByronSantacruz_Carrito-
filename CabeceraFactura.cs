using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_Carrito
{
    public class CabeceraFactura
    {
        public CabeceraFactura()
        {
        }
        //Creamos la clase cliente
        //public class MyProperty { get; set; }
        public Cliente ClienteCabecera { get; set; }
        public Empresa EmpresaCabecera { get; set; }
    }
}

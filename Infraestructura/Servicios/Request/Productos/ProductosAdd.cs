using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Servicios.Request.Productos
{
    public class ProductosAdd
    {
        public string nombre { get; set; }
        public int tipo { get; set; }

        public ProductosAdd()
        {
            tipo = 0;
        }
    }
}

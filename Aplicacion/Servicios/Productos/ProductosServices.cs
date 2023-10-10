using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.Request;
using Aplicacion.Response.Productos;
using Infraestructura.Servicios.Productos;

namespace Aplicacion.Servicios.Productos
{
    public class ProductosServices : IProductosService
    {
        public Requests Add(PostProductos model)
        {
            Requests rpta = new Requests();
            ProductoServices prod = new ProductoServices();

            try
            {
                prod.Add(model.nombre, model.tipo);
                rpta.exito = 1;
            }
            catch (Exception ex)
            {
                rpta.mensaje = ex.Message;
            }

            return rpta;
        }
    }
}

using Aplicacion.Request;
using Aplicacion.Response.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios.Productos
{
    public interface IProductosService
    {
        public Requests Add(PostProductos model);
    }
}

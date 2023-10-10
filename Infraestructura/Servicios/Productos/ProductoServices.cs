using Azure.Core;
using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades.Productos;
using Infraestructura.Servicios.Request.Productos;

namespace Infraestructura.Servicios.Productos
{
    public class ProductoServices
    {
        

        public void Add(string nombre, int tipo)
        {
            Producto prod = new Producto();

            using (ProductosDbContext con = new ProductosDbContext())
            {
                prod.nombre = nombre;
                prod.tipoId = tipo;

                con.Productos.Add(prod);
                con.SaveChanges();
            }
           
        }

        
    }
}

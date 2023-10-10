using Aplicacion.Request;
using Aplicacion.Response.Productos;
using Aplicacion.Servicios.Productos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private readonly IProductosService prod;

        
        public ProductoController(IProductosService _prod)
        {
            prod = _prod;
        }

        [HttpPost]
        public IActionResult Add(PostProductos model)
        {
            Requests rpta = new Requests();
            rpta = prod.Add(model);
            return Ok(rpta);
        }
    }
}

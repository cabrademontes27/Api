using plantilla.Modelo;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controladores
{
    [ApiController]
    [Route("cliente")]
    public class ProductosController : ControllerBase 
    {
        [HttpGet]
        [Route("listar")]

        public ActionResult<List<Producto>> listarProductos()
        {
           var productos = new List<Producto>
           {
                new Producto { Id = 1, Nombre = "Producto A", Precio = 100.50, Stock = 10 },
                new Producto { Id = 2, Nombre = "Producto B", Precio = 200.00, Stock = 5 },
           };
           return Ok(productos);
        }

    
    }
}
using APi.Modelos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controladores
{
    
    //no se si es referencia a una funcion o nombre de algo mio
    [Route("api/[controller]")]
    // indicara que es un controlador
    [ApiController] 
    
    public class ControladorProductos : ControllerBase
    {
        private static List<Producto> productos = new()
        {
            new Producto { Id = 1, Nombre = "Producto A", Precio = 100.50, Stock = 10 },
            new Producto { Id = 2, Nombre = "Producto B", Precio = 200.00, Stock = 5 },
            new Producto { Id = 3, Nombre = "Producto C", Precio = 300.75, Stock = 15 }
        };


        //GET /api/productos quiero pensar que ira el http
        [HttpGet]
        // al parecer optiene la lista y devuelve la lista de productos
        public IActionResult GetProductos()
        {
            return Ok(productos);
        }

        //Post / api /productos  aqui agreagara uni nuevo

        [HttpPost]
        public IActionResult agregarProducto(Producto producto)
        {
            //regresara el producto creado
            productos.Add(producto);
            return Created("",  producto);
        }
    }
}
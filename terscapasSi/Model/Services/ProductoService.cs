using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terscapasSi.Model.Context;
using terscapasSi.Model.Entities;

namespace terscapasSi.Model.Services
{
    internal class ProductoService
    {
        private readonly AplicationDbContext _context;

        public ProductoService()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppEjemplo;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            var optionsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            _context = new AplicationDbContext(optionsBuilder.Options);
        }


        //metodo para agregar o crear producto
        public bool CrearProducto(Producto nuevoProducto)
        {
            try
            {
                _context.Productos.Add(nuevoProducto);//agrega producto
                _context.SaveChanges();
                return true;//devuelve true que se agrego
            }
            catch
            {
                return false; // devuelve false si hay un error
            }


        }

        //metodo para obtener all productos
        public List<Producto> ObtenerTodos()
        {
            return _context.Productos.ToList();//lista completa de productos
        }

        //buscar un producto por ID
        public Producto ObtenerPorId(int id)
        {
            return _context.Productos.Where(c => c.Id == id).FirstOrDefault(); // expresion lambda lamretorna el mproducto con el id buscado
        }

        //metodo para actualizar un producto existente
        public bool ActualizarProducto(int id, Producto productoActualizado)
        {
            try
            {
                var producto = ObtenerPorId(id);//buscamos por id

                if (producto != null)
                {
                    //remmplaza ls valores
                    producto.Name = productoActualizado.Name;
                    producto.CodigoBarras = productoActualizado.CodigoBarras;
                    producto.Descripcion = productoActualizado.Descripcion;
                    producto.Precio = productoActualizado.Precio;
                    producto.Categoria = productoActualizado.Categoria;
                    producto.Stock = productoActualizado.Stock;
                    _context.SaveChanges();
                    return true;
                    //true indica que de actualizo correctamente 

                }
                return false; // no se encontro 
            }
            catch
            {
                return false; // ocurrio un error
            }

        }


        // metodo para eliminar producto
        public bool EliminarProducto(int id)
        {
            try
            {
                var producto = ObtenerPorId(id); //busca por id

                if (producto != null)
                {
                    _context.Productos.Remove(producto); // elimina el producto
                    return true;

                }
                return false; // si no se encontro el producto para elimianr


            }
            catch
            {
                return false;   //error al intentar eliminar 
            }
        }
    }



}

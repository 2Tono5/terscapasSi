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
    internal class CategoriaService
    {

        private readonly AplicationDbContext _context;

        public CategoriaService() 
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppEjemplo;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            var optionsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            _context = new AplicationDbContext(optionsBuilder.Options);
        }

        //*************************************
        //metodo para crear una nueva categoria
        public bool CrearCategoria(Categoria nuevaCategoria)
        {
            try
            {
                _context.Categorias.Add(nuevaCategoria); //agrega la nueva categoria
                _context.SaveChanges();
                return true; // exito

            }
            catch
            {
                return false; // en caos de error 
            }
        }
        //*************************************
        //metodo para obtener todas las categorias 
        public List<Categoria> ObtenerTodas()
        {
            return _context.Categorias.ToList(); // retorna la lista de categoias 
        }

        //metodo ob categoria por ID
        public Categoria ObtenerPorID(int id)
        {
            return _context.Categorias.Where(c => c.Id == id).FirstOrDefault();
            //busca categoria por id
        }
        //*************************************
        //metodo actualizar caterogia 
        public bool ActualizarCategoria(int id, Categoria categoriaActualizada)
        {
            try
            {
                var categoria = ObtenerPorID(id);

                if (categoria != null)
                {
                    categoria.Name = categoriaActualizada.Name;
                    categoria.Activa = categoriaActualizada.Activa;
                    _context.SaveChanges();
                    return true;
                    //actualiza con exito

                }
                return false; // no encuentra categoria 


            }
            catch
            {
                return false; //error durante 
            }

        }

        //*************************************
        //metodo opara eliminar una categoria 
        public bool EliminarCategoria(int id)
        {
            try
            {
                var categoria = ObtenerPorID(id); // bjusca actegoria 
                if (categoria != null)
                {
                    _context.Remove(categoria); //elimina categoria
                    return true;

                }
                return false; // cat no encontrada

            }
            catch
            {
                return false; //cat no encontrada
            }
        }




    }
}

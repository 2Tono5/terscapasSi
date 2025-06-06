﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terscapasSi.Model.Context;
using terscapasSi.Model.Entities;


namespace terscapasSi.Model.Services
{
    internal class UserService
    {

        private readonly AplicationDbContext _context;

        public UserService()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppEjemplo;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            var optionsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            _context = new AplicationDbContext(optionsBuilder.Options);
        }
        //**************************************
        //crear usuario nuevo
        public bool CrearUsuario(User nuevoUsuario)
        {
            try
            {
                _context.Users.Add(nuevoUsuario); //agregar nuevo usuaroio a la list
                _context.SaveChanges();
                return true;


            }
            catch
            {
                return false;
            }
        }

        //**************************************
        //obtener usuarios por id
        public User ObtenerPorID(int id)
        {
            return _context.Users.Where(c => c.Id == id).FirstOrDefault();
        }


        //**************************************
        //actualizar usuario existente
        public bool ActualizarUsuario(int id, User usuarioActualizado)
        {
            try
            {
                var usuario = ObtenerPorID(id);

                if (usuario != null)
                {
                    usuario.Name = usuarioActualizado.Name;
                    usuario.Email = usuarioActualizado.Email;
                    usuario.Password = usuarioActualizado.Password;
                    usuario.Activo = usuarioActualizado.Activo;
                    _context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        //**************************************
        //eliminar usuario por Id
        public bool EliminarUsuario(int id)
        {
            try
            {
                var usuario = ObtenerPorID(id);
                if (usuario != null)
                {
                    _context.Users.Remove(usuario);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }



    }
}

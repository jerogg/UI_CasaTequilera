using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConexionABaseDeDatos
    {
        CasaTequileraBarrilitoEntities1 casaTequileraBarrilitoEntities = new CasaTequileraBarrilitoEntities1();
        public List<Usuario> ObtenerTodosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario> ();
            try
            {
                usuarios = casaTequileraBarrilitoEntities.Usuario.ToList();
            }
            catch (Exception ex) {

                throw ex;
            }

            return usuarios;
        }

        public bool ValidarUsuario(string nombre, string contrasena)
        {
            bool resultado = false;
            try
            {
                resultado = casaTequileraBarrilitoEntities.Usuario.Select(x => x.Nombre_Corto == nombre && x.Contrasenia == contrasena).First();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return resultado;
        }

        public bool GuardarUsuario(int IdUsuario, string nombre, string contrasenia, string nombreCompleto, byte[] foto)
        {
            bool resultado = false;
            try
            {
                if (IdUsuario > 0) //editar usuario
                {
                    Usuario usuarioExistente = casaTequileraBarrilitoEntities.Usuario.Where(usario => usario.IdUsuario == IdUsuario).FirstOrDefault();
                    usuarioExistente.Nombre = nombreCompleto;
                    usuarioExistente.Contrasenia = contrasenia;
                    usuarioExistente.Nombre_Corto = nombre;
                    usuarioExistente.Foto = foto;
                    casaTequileraBarrilitoEntities.SaveChanges();
                    resultado = true;

                }
                else //nuevo usuario
                {
                    Usuario nuevoUsuario = new Usuario();
                    nuevoUsuario.Nombre = nombreCompleto;
                    nuevoUsuario.Contrasenia = contrasenia;
                    nuevoUsuario.Nombre_Corto = nombre;
                    nuevoUsuario.Foto = foto;

                    casaTequileraBarrilitoEntities.Usuario.Add(nuevoUsuario);
                    casaTequileraBarrilitoEntities.SaveChanges();
                    resultado = true;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return resultado;
        }
       
        public Usuario ObtenerDatosPorUsuario(int IdUsuario)
        {
            Usuario usuario = new Usuario();
            try
            {
                usuario = casaTequileraBarrilitoEntities.Usuario.Where(usario => usario.IdUsuario == IdUsuario).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return usuario;
        }

        public bool EliminarUsuario(int IdUsuario)
        {
            Usuario usuario = new Usuario();
            bool usuarioEliminado = false;
            try
            {
                usuario = casaTequileraBarrilitoEntities.Usuario.Where(usario => usario.IdUsuario == IdUsuario).FirstOrDefault();
                casaTequileraBarrilitoEntities.Usuario.Remove(usuario);
                casaTequileraBarrilitoEntities.SaveChanges();
                usuarioEliminado = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return usuarioEliminado;
        }

    }
}

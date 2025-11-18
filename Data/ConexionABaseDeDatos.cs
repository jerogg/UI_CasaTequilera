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
        public List<Usuario> ObtenerUsuarios()
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
                //aqui la conversion de la contrasenia a byte[]
                //byte[] contraseniaBytes = Encoding.UTF8.GetBytes(contrasena);

                resultado = casaTequileraBarrilitoEntities.Usuario.Select(x => x.Nombre_Corto == nombre && x.Contrasenia == contrasena).First();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return resultado;
        }

        public bool GuardarUsuario(string nombre, string contrasenia, string nombreCompleto, byte[] foto)
        {
            bool resultado = false;
            try
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
            catch (Exception ex)
            {

                throw ex;
            }

            return resultado;
        }
        public bool EliminarUsuario(string id)
        {
            bool resultado = false;
            try
            {
                //aqui la conversion de la contrasenia a byte[]
                //byte[] contraseniaBytes = Encoding.UTF8.GetBytes(contrasena);

                //resultado = casaTequileraBarrilitoEntities.Usuario.Select(x => x.Nombre_Corto == nombre && x.Contrasenia == contrasena).First();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return resultado;
        }
        public bool PasarUsuario(string nombre, string contrasena)
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
    }
}

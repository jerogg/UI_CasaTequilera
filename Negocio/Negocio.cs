using Data;
using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;

namespace Negocio
{
    public class Negocio
    {
        Datos.ConexionABaseDeDatos datos = new Datos.ConexionABaseDeDatos();
        public List<string> ObtenerUsuarios()
        {
            List<string> nombresUsuarios = new List<string>();
            try
            {
                nombresUsuarios = datos.ObtenerUsuarios().Select(x => x.Nombre_Corto).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nombresUsuarios;
        }

        public List<Usuario> ObtenerDatosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                usuarios = datos.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return usuarios;
        }

        public bool ValidarUsuario(string usuario, string contrasena)
        {
                    try
                    {
                        return datos.ValidarUsuario(usuario, contrasena);
                    }
                    catch (Exception)
                    {
                        return false;
                    }
        }
        public bool GuardarUsuario(string usuario, string nombreCompleto, string contrasenia, Image Foto)
        {
            try
            {
                //validar que los parametros no esten vacios
                //if alguno es vacio return falso
                //else
                if (usuario == null || nombreCompleto == null || contrasenia == null || Foto is null)
                {
                    return false;
                }
                else
                {
                    ImageConverter converter = new ImageConverter(); 
                    return datos.GuardarUsuario(usuario, contrasenia, nombreCompleto, (byte[])converter.ConvertTo(Foto, typeof(byte[])));
                }       
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarUsuario(object id)
        {

            throw new NotImplementedException();
        }
    }
}

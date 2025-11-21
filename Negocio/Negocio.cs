using Data;
using Datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
                nombresUsuarios = datos.ObtenerTodosUsuarios().Select(x => x.Nombre_Corto).ToList();
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
                usuarios = datos.ObtenerTodosUsuarios();
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
        public bool GuardarUsuario(int idUsuario, string usuario, string nombreCompleto, string contrasenia, Image Foto)
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
                    return datos.GuardarUsuario(idUsuario, usuario, contrasenia, nombreCompleto, (byte[])converter.ConvertTo(Foto, typeof(byte[])));
                }       
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarUsuario(int IdUsuario)
        {
            bool usuarioEliminado = false;
                try
                {
                usuarioEliminado = datos.EliminarUsuario(IdUsuario);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return usuarioEliminado;
        }

        public Usuario ObtenerDatosPorUsuario(int IdUsuario)
        {
            Usuario usuario = new Usuario();
            try
            {
                usuario = datos.ObtenerDatosPorUsuario(IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return usuario;
        }

        public Image ConvertirBytesAImagen(byte[] imagenBytes)
        {
            Image foto = null;
            try
            {
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    // Crear un objeto Image a partir del MemoryStream
                    foto = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return foto;
        }

        
        public List<Departamentos> ObtenerDepartamentos()
        {
            List<Departamentos> departamento = new List<Departamentos>();
            try
            {
                departamento = datos.ObtenerDatosDepartamentos();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return departamento;
        }

        public bool EliminarDepartamento(int IdDepartamento)
        {
            bool departamentoEliminado = false;
            try
            {
                departamentoEliminado = datos.EliminarDepartamento(IdDepartamento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return departamentoEliminado;
        }
    }
}

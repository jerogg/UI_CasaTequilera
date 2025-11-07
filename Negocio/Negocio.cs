using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
                nombresUsuarios = datos.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nombresUsuarios;
        }
        SqlCommand comando;
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
    }
}

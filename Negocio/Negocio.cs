using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

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
    }
}

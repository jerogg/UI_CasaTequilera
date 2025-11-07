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
        public List<string> ObtenerUsuarios()
        {
            List<string> nombresUsuarios = new List<string> ();
            try
            {
                nombresUsuarios = casaTequileraBarrilitoEntities.Usuario.Select(x => x.Nombre_Corto).ToList();
            }
            catch (Exception ex) {

                throw ex;
            }

            return nombresUsuarios;
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
    }
}

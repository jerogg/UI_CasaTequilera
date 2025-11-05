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
        CasaTequileraBarrilitoEntities casaTequileraBarrilitoEntities = new CasaTequileraBarrilitoEntities ();
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
    }
}

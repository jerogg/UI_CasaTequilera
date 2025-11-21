using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaTequileraElBarrilito.Productos
{
    public partial class Departamentos : UserControl
    {
        public int idUsuario = 0;
        public int idDepartamento = 0;
        Negocio.Negocio negocio = new Negocio.Negocio();

        public Departamentos()
        {
            InitializeComponent();
        }

        private void btnNuevoDepto_Click(object sender, EventArgs e)
        {
            try
            {
                idUsuario = 0;
                LimpiarCamposGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        void LimpiarCamposGrid()
        {
            txtNuevoDepto.Text = string.Empty;

            CargarDepartamentos();
        }
        public void CargarDepartamentos()
        {
            dgvDepartamento.DataSource = negocio.ObtenerDepartamentos();
        }

        private void dgvDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarDepto_Click(object sender, EventArgs e)
        {
            try
            {
                var result = negocio.EliminarDepartamento(idDepartamento);

                if (result == false)
                {
                    MessageBox.Show("Departamento no eliminado");
                }
                else
                {
                    MessageBox.Show("Departamento eliminado");
                    LimpiarCamposGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}

using CasaTequileraElBarrilito.Productos;
using Data;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaTequileraElBarrilito
{
    public partial class ProductosControl : UserControl
    {
        public ProductosControl()
        {
            InitializeComponent();
        }

        public void btnDepartamentos_Click(object sender, EventArgs e)
        {
            pnlProductosPrincipal.Controls.Clear(); // Limpiar el panel antes de agregar un nuevo control
            Productos.Departamentos departamento = new Productos.Departamentos();// Crear una instancia del UserControl que deseas mostrar
            departamento.Dock = DockStyle.Fill;// Ajustar el UserControl para que llene el panel
            pnlProductosPrincipal.Controls.Add(departamento);// Agregar el UserControl al panel
            departamento.CargarDepartamentos();
            DataGridView dgv = departamento.Controls.OfType<DataGridView>().FirstOrDefault();
        }

        private void pnlProductosPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}

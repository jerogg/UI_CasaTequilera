using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
  

namespace CasaTequileraElBarrilito
{
    public partial class Login : Form
    {
        Negocio.Negocio negocio = new Negocio.Negocio();
        public Login()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblContrasena_Click(object sender, EventArgs e)
        {

        }

        

        private void Login_Load(object sender, EventArgs e)
        {
            cbxUsuario.DataSource = negocio.ObtenerUsuarios();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            string usuario = cbxUsuario.Text;
            string contraseña = txtContrasena.Text;

            bool acceso = negocio.ValidarUsuario(usuario, contraseña);

            if (acceso)
            {
                Ventas ventas = new Ventas();
                ventas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            
        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}

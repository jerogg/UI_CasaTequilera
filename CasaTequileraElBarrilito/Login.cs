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
        Negocio.Negocio class1 = new Negocio.Negocio();
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
            cbxUsuario.DataSource = class1.ObtenerUsuarios();
        }

        
    }
}

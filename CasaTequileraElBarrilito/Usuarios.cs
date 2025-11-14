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
    public partial class Usuarios : Form
    {
        Negocio.Negocio negocio = new Negocio.Negocio();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cajeros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'casaTequileraBarrilitoDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            CargaUsuarios();

        }

        void CargaUsuarios()
        {
            //this.usuarioTableAdapter.Fill(this.casaTequileraBarrilitoDataSet.Usuario);
            //this.usuarioTableAdapter.Fill(negocio.ObtenerUsuarios());
            dgvUsuarios.DataSource = negocio.ObtenerDatosUsuarios();
        }
       

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsuarios.DataSource = negocio.ObtenerUsuarios();
        }

        private void btnCancelarConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pbxFotoUsuarios_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogFotoUsuario = new OpenFileDialog();
            openFileDialogFotoUsuario.Filter = "Archivos de imagen (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            if (openFileDialogFotoUsuario.ShowDialog() == DialogResult.OK)
            {
                pbxFotoUsuario.Image = Image.FromFile(openFileDialogFotoUsuario.FileName);
                pbxFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtNuevoUsuario.Text;
                string contrasena = txtNuevaContrasena.Text;
                string nombreCompleto = txtNombreCompleto.Text;
                Image foto = pbxFotoUsuario.Image;

                var result = negocio.GuardarUsuario(usuario, nombreCompleto, contrasena, foto);

                if (result == false)
                {
                    MessageBox.Show("Datos invalidos del usuario");
                }
                else
                {
                    MessageBox.Show("Usuario se guardo exitosamente");
                    //limpieza de campos y actualizar grid de usuarios
                    LimpiarCamposGrid();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        void LimpiarCamposGrid()
        {
            txtNuevoUsuario.Text = string.Empty;
            txtNuevaContrasena.Text = string.Empty;
            txtNombreCompleto.Text = string.Empty;
            pbxFotoUsuario.Image = null;

            CargaUsuarios();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}

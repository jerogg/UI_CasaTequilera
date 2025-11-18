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

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'casaTequileraBarrilitoDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            CargaUsuarios();

        }

        void CargaUsuarios()
        {
            dgvUsuario.DataSource = negocio.ObtenerDatosUsuarios();
        }
       

        private void btnCancelarConfig_Click(object sender, EventArgs e)
        {
            
        }

        private void pbxFotoUsuarios_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogFotoUsuarios = new OpenFileDialog();
            openFileDialogFotoUsuarios.Filter = "Archivos de imagen (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            if (openFileDialogFotoUsuarios.ShowDialog() == DialogResult.OK)
            {
                pbxFotoUsuarios.Image = Image.FromFile(openFileDialogFotoUsuarios.FileName);
                pbxFotoUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
        
        }

        void LimpiarCamposGrid()
        {
            txtUsuarioN.Text = string.Empty;
            txtContrasenaN.Text = string.Empty;
            txtNombreCom.Text = string.Empty;
            pbxFotoUsuarios.Image = null;

            CargaUsuarios();
        }
                
        private void GuardarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuarioN.Text;
                string contrasena = txtContrasenaN.Text;
                string nombreCompleto = txtNombreCom.Text;
                Image foto = pbxFotoUsuarios.Image;

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

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            //obtener el Id del usuario desde la fila seleccionada
            // Obtener la primera fila seleccionada
            if(dgvUsuario.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvUsuario.SelectedRows[0];

                object idUsuario = Convert.ToInt32(filaSeleccionada.Cells["IdUsuario"].Value);

                //Vas a ir a base de datos para obtener informacion de ese usuario
            }
        }
    }
}

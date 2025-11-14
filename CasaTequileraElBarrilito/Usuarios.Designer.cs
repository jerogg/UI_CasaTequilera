using System;

namespace CasaTequileraElBarrilito
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Usuarios
            // 
            this.ClientSize = new System.Drawing.Size(522, 328);
            this.Name = "Usuarios";
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxFotoUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private CasaTequileraBarrilitoDataSet casaTequileraBarrilitoDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private CasaTequileraBarrilitoDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancelarConfig;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.OpenFileDialog openFileDialogFotoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;

    }
}
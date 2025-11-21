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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnImpresoraTicket = new System.Windows.Forms.Button();
            this.btnCajonBascula = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEliminarUsuarios = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.casaTequileraBarrilitoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casaTequileraBarrilitoDataSet1 = new CasaTequileraElBarrilito.CasaTequileraBarrilitoDataSet();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pbxFotoUsuarios = new System.Windows.Forms.PictureBox();
            this.txtNombreCom = new System.Windows.Forms.TextBox();
            this.txtContrasenaN = new System.Windows.Forms.TextBox();
            this.txtUsuarioN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.GuardarUsuarios = new System.Windows.Forms.Button();
            this.btnCancelarUsuario = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSet1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoUsuarios)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnImpresoraTicket);
            this.panel5.Controls.Add(this.btnCajonBascula);
            this.panel5.Controls.Add(this.btnGeneral);
            this.panel5.Location = new System.Drawing.Point(3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(747, 50);
            this.panel5.TabIndex = 0;
            // 
            // btnImpresoraTicket
            // 
            this.btnImpresoraTicket.Location = new System.Drawing.Point(267, 3);
            this.btnImpresoraTicket.Name = "btnImpresoraTicket";
            this.btnImpresoraTicket.Size = new System.Drawing.Size(144, 39);
            this.btnImpresoraTicket.TabIndex = 3;
            this.btnImpresoraTicket.Text = "Impresora y Ticket";
            this.btnImpresoraTicket.UseVisualStyleBackColor = true;
            // 
            // btnCajonBascula
            // 
            this.btnCajonBascula.Image = ((System.Drawing.Image)(resources.GetObject("btnCajonBascula.Image")));
            this.btnCajonBascula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCajonBascula.Location = new System.Drawing.Point(108, 3);
            this.btnCajonBascula.Name = "btnCajonBascula";
            this.btnCajonBascula.Size = new System.Drawing.Size(153, 39);
            this.btnCajonBascula.TabIndex = 2;
            this.btnCajonBascula.Text = "Cajon y Bascula";
            this.btnCajonBascula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCajonBascula.UseVisualStyleBackColor = true;
            // 
            // btnGeneral
            // 
            this.btnGeneral.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneral.Image")));
            this.btnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.Location = new System.Drawing.Point(9, 3);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(97, 39);
            this.btnGeneral.TabIndex = 1;
            this.btnGeneral.Text = "General";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneral.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnEliminarUsuarios);
            this.panel6.Controls.Add(this.btnNuevoUsuario);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(3, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(750, 69);
            this.panel6.TabIndex = 1;
            // 
            // btnEliminarUsuarios
            // 
            this.btnEliminarUsuarios.Location = new System.Drawing.Point(507, 27);
            this.btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            this.btnEliminarUsuarios.Size = new System.Drawing.Size(122, 39);
            this.btnEliminarUsuarios.TabIndex = 5;
            this.btnEliminarUsuarios.Text = "Eliminar Usuario";
            this.btnEliminarUsuarios.UseVisualStyleBackColor = true;
            this.btnEliminarUsuarios.Click += new System.EventHandler(this.btnEliminarUsuarios_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(390, 27);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(111, 39);
            this.btnNuevoUsuario.TabIndex = 4;
            this.btnNuevoUsuario.Text = "Nuevo Usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuarios";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AutoGenerateColumns = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.IdUsuario,
            this.Foto});
            this.dgvUsuario.DataSource = this.casaTequileraBarrilitoDataSet1BindingSource;
            this.dgvUsuario.Location = new System.Drawing.Point(4, 131);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.RowHeadersWidth = 51;
            this.dgvUsuario.RowTemplate.Height = 24;
            this.dgvUsuario.ShowCellToolTips = false;
            this.dgvUsuario.Size = new System.Drawing.Size(310, 350);
            this.dgvUsuario.TabIndex = 9;
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            this.dgvUsuario.SelectionChanged += new System.EventHandler(this.dgvUsuario_SelectionChanged);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre_Corto";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.MinimumWidth = 6;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 125;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.Width = 125;
            // 
            // casaTequileraBarrilitoDataSet1BindingSource
            // 
            this.casaTequileraBarrilitoDataSet1BindingSource.DataSource = this.casaTequileraBarrilitoDataSet1;
            this.casaTequileraBarrilitoDataSet1BindingSource.Position = 0;
            // 
            // casaTequileraBarrilitoDataSet1
            // 
            this.casaTequileraBarrilitoDataSet1.DataSetName = "CasaTequileraBarrilitoDataSet";
            this.casaTequileraBarrilitoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.pbxFotoUsuarios);
            this.panel8.Controls.Add(this.txtNombreCom);
            this.panel8.Controls.Add(this.txtContrasenaN);
            this.panel8.Controls.Add(this.txtUsuarioN);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.lblusuario);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(427, 137);
            this.panel8.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Este Usuario podría...";
            // 
            // pbxFotoUsuarios
            // 
            this.pbxFotoUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFotoUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxFotoUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pbxFotoUsuarios.Image")));
            this.pbxFotoUsuarios.Location = new System.Drawing.Point(309, 14);
            this.pbxFotoUsuarios.Name = "pbxFotoUsuarios";
            this.pbxFotoUsuarios.Size = new System.Drawing.Size(95, 100);
            this.pbxFotoUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFotoUsuarios.TabIndex = 7;
            this.pbxFotoUsuarios.TabStop = false;
            this.pbxFotoUsuarios.Click += new System.EventHandler(this.pbxFotoUsuarios_Click);
            // 
            // txtNombreCom
            // 
            this.txtNombreCom.Location = new System.Drawing.Point(124, 75);
            this.txtNombreCom.Name = "txtNombreCom";
            this.txtNombreCom.Size = new System.Drawing.Size(166, 22);
            this.txtNombreCom.TabIndex = 8;
            // 
            // txtContrasenaN
            // 
            this.txtContrasenaN.Location = new System.Drawing.Point(124, 42);
            this.txtContrasenaN.Name = "txtContrasenaN";
            this.txtContrasenaN.Size = new System.Drawing.Size(166, 22);
            this.txtContrasenaN.TabIndex = 7;
            // 
            // txtUsuarioN
            // 
            this.txtUsuarioN.Location = new System.Drawing.Point(124, 14);
            this.txtUsuarioN.Name = "txtUsuarioN";
            this.txtUsuarioN.Size = new System.Drawing.Size(166, 22);
            this.txtUsuarioN.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nombre completo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Clave";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(64, 17);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(54, 16);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuario";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(320, 131);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(433, 306);
            this.panel7.TabIndex = 3;
            // 
            // GuardarUsuarios
            // 
            this.GuardarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("GuardarUsuarios.Image")));
            this.GuardarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarUsuarios.Location = new System.Drawing.Point(329, 442);
            this.GuardarUsuarios.Name = "GuardarUsuarios";
            this.GuardarUsuarios.Size = new System.Drawing.Size(152, 39);
            this.GuardarUsuarios.TabIndex = 4;
            this.GuardarUsuarios.Text = "Guardar Usuario";
            this.GuardarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarUsuarios.UseVisualStyleBackColor = true;
            this.GuardarUsuarios.Click += new System.EventHandler(this.GuardarUsuarios_Click);
            // 
            // btnCancelarUsuario
            // 
            this.btnCancelarUsuario.Location = new System.Drawing.Point(487, 443);
            this.btnCancelarUsuario.Name = "btnCancelarUsuario";
            this.btnCancelarUsuario.Size = new System.Drawing.Size(111, 39);
            this.btnCancelarUsuario.TabIndex = 4;
            this.btnCancelarUsuario.Text = "Cancelar";
            this.btnCancelarUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarUsuario.Click += new System.EventHandler(this.btnCancelarUsuario_Click);
            // 
            // Usuarios
            // 
            this.ClientSize = new System.Drawing.Size(763, 487);
            this.Controls.Add(this.btnCancelarUsuario);
            this.Controls.Add(this.GuardarUsuarios);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Name = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSet1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoUsuarios)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Button btnCancelarConfig;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCajonBascula;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.BindingSource casaTequileraBarrilitoDataSet1BindingSource;
        private CasaTequileraBarrilitoDataSet casaTequileraBarrilitoDataSet1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbxFotoUsuarios;
        private System.Windows.Forms.TextBox txtNombreCom;
        private System.Windows.Forms.TextBox txtContrasenaN;
        private System.Windows.Forms.TextBox txtUsuarioN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button GuardarUsuarios;
        private System.Windows.Forms.Button btnCancelarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.Button btnImpresoraTicket;
    }
}
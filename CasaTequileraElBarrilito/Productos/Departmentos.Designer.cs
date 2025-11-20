namespace CasaTequileraElBarrilito.Productos
{
    partial class Departmentos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDepartamento = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtUsuarioN = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNuevoDepto = new System.Windows.Forms.Button();
            this.btnEliminarDepto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 571);
            this.panel1.TabIndex = 0;
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.IdUsuario,
            this.Foto});
            this.dgvDepartamento.Location = new System.Drawing.Point(17, 121);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.RowHeadersWidth = 51;
            this.dgvDepartamento.RowTemplate.Height = 24;
            this.dgvDepartamento.ShowCellToolTips = false;
            this.dgvDepartamento.Size = new System.Drawing.Size(310, 359);
            this.dgvDepartamento.TabIndex = 10;
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
            // txtUsuarioN
            // 
            this.txtUsuarioN.Location = new System.Drawing.Point(76, 19);
            this.txtUsuarioN.Name = "txtUsuarioN";
            this.txtUsuarioN.Size = new System.Drawing.Size(166, 22);
            this.txtUsuarioN.TabIndex = 8;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(16, 22);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(54, 16);
            this.lblusuario.TabIndex = 7;
            this.lblusuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Departamentos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUsuarioN);
            this.panel2.Controls.Add(this.lblusuario);
            this.panel2.Location = new System.Drawing.Point(345, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 358);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEliminarDepto);
            this.panel3.Controls.Add(this.btnNuevoDepto);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(18, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 73);
            this.panel3.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 22);
            this.textBox1.TabIndex = 10;
            // 
            // btnNuevoDepto
            // 
            this.btnNuevoDepto.Location = new System.Drawing.Point(327, 20);
            this.btnNuevoDepto.Name = "btnNuevoDepto";
            this.btnNuevoDepto.Size = new System.Drawing.Size(177, 38);
            this.btnNuevoDepto.TabIndex = 11;
            this.btnNuevoDepto.Text = "Nuevo Departamento";
            this.btnNuevoDepto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDepto
            // 
            this.btnEliminarDepto.Location = new System.Drawing.Point(510, 20);
            this.btnEliminarDepto.Name = "btnEliminarDepto";
            this.btnEliminarDepto.Size = new System.Drawing.Size(177, 38);
            this.btnEliminarDepto.TabIndex = 12;
            this.btnEliminarDepto.Text = "Eliminar Departamento";
            this.btnEliminarDepto.UseVisualStyleBackColor = true;
            // 
            // Departmentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDepartamento);
            this.Controls.Add(this.panel1);
            this.Name = "Departmentos";
            this.Size = new System.Drawing.Size(803, 577);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.TextBox txtUsuarioN;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminarDepto;
        private System.Windows.Forms.Button btnNuevoDepto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

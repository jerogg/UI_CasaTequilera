namespace CasaTequileraElBarrilito.Productos
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxProductoInventario = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcionProd = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxSeccionBodega = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarProducto.Image")));
            this.btnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProducto.Location = new System.Drawing.Point(3, 543);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(160, 57);
            this.btnGuardarProducto.TabIndex = 8;
            this.btnGuardarProducto.Text = "Guardar Producto";
            this.btnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inventario";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbxProductoInventario
            // 
            this.cbxProductoInventario.AutoSize = true;
            this.cbxProductoInventario.Location = new System.Drawing.Point(67, 430);
            this.cbxProductoInventario.Name = "cbxProductoInventario";
            this.cbxProductoInventario.Size = new System.Drawing.Size(224, 20);
            this.cbxProductoInventario.TabIndex = 6;
            this.cbxProductoInventario.Text = "Este producto SI utiliza inventario";
            this.cbxProductoInventario.UseVisualStyleBackColor = true;
            this.cbxProductoInventario.CheckedChanged += new System.EventHandler(this.cbxProductoInventario_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cantidad Actual";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Minimo";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Location = new System.Drawing.Point(160, 37);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(200, 22);
            this.txtDescripcionProd.TabIndex = 10;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(160, 71);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(200, 22);
            this.txtPrecioCosto.TabIndex = 11;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.IdUsuario,
            this.Foto});
            this.dgvUsuario.Location = new System.Drawing.Point(28, 136);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.RowHeadersWidth = 51;
            this.dgvUsuario.RowTemplate.Height = 24;
            this.dgvUsuario.ShowCellToolTips = false;
            this.dgvUsuario.Size = new System.Drawing.Size(332, 122);
            this.dgvUsuario.TabIndex = 12;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.Width = 125;
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
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre_Corto";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(160, 3);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(200, 22);
            this.txtCodigoBarras.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxSeccionBodega);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxProductoInventario);
            this.panel1.Controls.Add(this.dgvUsuario);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPrecioCosto);
            this.panel1.Controls.Add(this.txtCodigoBarras);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDescripcionProd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 522);
            this.panel1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Seccion de Bodega";
            // 
            // cbxSeccionBodega
            // 
            this.cbxSeccionBodega.FormattingEnabled = true;
            this.cbxSeccionBodega.Location = new System.Drawing.Point(160, 319);
            this.cbxSeccionBodega.Name = "cbxSeccionBodega";
            this.cbxSeccionBodega.Size = new System.Drawing.Size(191, 24);
            this.cbxSeccionBodega.TabIndex = 15;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarProducto);
            this.Name = "Productos";
            this.Size = new System.Drawing.Size(1304, 605);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxProductoInventario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcionProd;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxSeccionBodega;
        private System.Windows.Forms.Label label9;
    }
}

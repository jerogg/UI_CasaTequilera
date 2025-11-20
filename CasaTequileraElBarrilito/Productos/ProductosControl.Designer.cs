namespace CasaTequileraElBarrilito
{
    partial class ProductosControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosControl));
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeccionBodega = new System.Windows.Forms.Button();
            this.btnDepartamentos = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.pnlProductosPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoProducto.Image")));
            this.btnNuevoProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProducto.Location = new System.Drawing.Point(3, 4);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(100, 48);
            this.btnNuevoProducto.TabIndex = 1;
            this.btnNuevoProducto.Text = "Nuevo ";
            this.btnNuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSeccionBodega);
            this.panel1.Controls.Add(this.btnDepartamentos);
            this.panel1.Controls.Add(this.btnEliminarProducto);
            this.panel1.Controls.Add(this.btnModificarProducto);
            this.panel1.Controls.Add(this.btnNuevoProducto);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 52);
            this.panel1.TabIndex = 2;
            // 
            // btnSeccionBodega
            // 
            this.btnSeccionBodega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeccionBodega.Location = new System.Drawing.Point(469, 4);
            this.btnSeccionBodega.Name = "btnSeccionBodega";
            this.btnSeccionBodega.Size = new System.Drawing.Size(128, 48);
            this.btnSeccionBodega.TabIndex = 5;
            this.btnSeccionBodega.Text = "Secciones Bodega";
            this.btnSeccionBodega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeccionBodega.UseVisualStyleBackColor = true;
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartamentos.Location = new System.Drawing.Point(335, 4);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Size = new System.Drawing.Size(128, 48);
            this.btnDepartamentos.TabIndex = 4;
            this.btnDepartamentos.Text = "Departamentos ";
            this.btnDepartamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartamentos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(222, 4);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(107, 48);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarProducto.Image")));
            this.btnModificarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProducto.Location = new System.Drawing.Point(109, 4);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(107, 48);
            this.btnModificarProducto.TabIndex = 2;
            this.btnModificarProducto.Text = "Modificar ";
            this.btnModificarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // pnlProductosPrincipal
            // 
            this.pnlProductosPrincipal.Location = new System.Drawing.Point(1, 61);
            this.pnlProductosPrincipal.Name = "pnlProductosPrincipal";
            this.pnlProductosPrincipal.Size = new System.Drawing.Size(751, 657);
            this.pnlProductosPrincipal.TabIndex = 3;
            // 
            // ProductosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlProductosPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "ProductosControl";
            this.Size = new System.Drawing.Size(782, 721);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnDepartamentos;
        private System.Windows.Forms.Button btnSeccionBodega;
        private System.Windows.Forms.Panel pnlProductosPrincipal;
    }
}

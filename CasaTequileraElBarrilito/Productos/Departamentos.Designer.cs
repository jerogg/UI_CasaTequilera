namespace CasaTequileraElBarrilito.Productos
{
    partial class Departamentos
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminarDepto = new System.Windows.Forms.Button();
            this.btnNuevoDepto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelarDepto = new System.Windows.Forms.Button();
            this.btnGuardarDepto = new System.Windows.Forms.Button();
            this.txtNuevoDepto = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casaTequileraBarrilitoDataSet1 = new CasaTequileraElBarrilito.CasaTequileraBarrilitoDataSet1();
            this.departamentosTableAdapter = new CasaTequileraElBarrilito.CasaTequileraBarrilitoDataSet1TableAdapters.DepartamentosTableAdapter();
            this.casaTequileraBarrilitoDataSet2 = new CasaTequileraElBarrilito.CasaTequileraBarrilitoDataSet2();
            this.departamentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosTableAdapter1 = new CasaTequileraElBarrilito.CasaTequileraBarrilitoDataSet2TableAdapters.DepartamentosTableAdapter();
            this.dgvDepartamento = new System.Windows.Forms.DataGridView();
            this.casaTequileraBarrilitoDataSet = new CasaTequileraElBarrilito.CasaTequileraBarrilitoDataSet();
            this.casaTequileraBarrilitoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casaTequileraBarrilitoDataSet3 = new CasaTequileraElBarrilito.CasaTequileraBarrilitoDataSet3();
            this.departamentosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosTableAdapter2 = new CasaTequileraElBarrilito.CasaTequileraBarrilitoDataSet3TableAdapters.DepartamentosTableAdapter();
            this.idDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDepartamento);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 571);
            this.panel1.TabIndex = 0;
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
            // btnEliminarDepto
            // 
            this.btnEliminarDepto.Location = new System.Drawing.Point(510, 20);
            this.btnEliminarDepto.Name = "btnEliminarDepto";
            this.btnEliminarDepto.Size = new System.Drawing.Size(177, 38);
            this.btnEliminarDepto.TabIndex = 12;
            this.btnEliminarDepto.Text = "Eliminar Departamento";
            this.btnEliminarDepto.UseVisualStyleBackColor = true;
            this.btnEliminarDepto.Click += new System.EventHandler(this.btnEliminarDepto_Click);
            // 
            // btnNuevoDepto
            // 
            this.btnNuevoDepto.Location = new System.Drawing.Point(327, 20);
            this.btnNuevoDepto.Name = "btnNuevoDepto";
            this.btnNuevoDepto.Size = new System.Drawing.Size(177, 38);
            this.btnNuevoDepto.TabIndex = 11;
            this.btnNuevoDepto.Text = "Nuevo Departamento";
            this.btnNuevoDepto.UseVisualStyleBackColor = true;
            this.btnNuevoDepto.Click += new System.EventHandler(this.btnNuevoDepto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 22);
            this.textBox1.TabIndex = 10;
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
            this.panel2.Controls.Add(this.btnCancelarDepto);
            this.panel2.Controls.Add(this.btnGuardarDepto);
            this.panel2.Controls.Add(this.txtNuevoDepto);
            this.panel2.Controls.Add(this.lblusuario);
            this.panel2.Location = new System.Drawing.Point(345, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 358);
            this.panel2.TabIndex = 9;
            // 
            // btnCancelarDepto
            // 
            this.btnCancelarDepto.Location = new System.Drawing.Point(183, 62);
            this.btnCancelarDepto.Name = "btnCancelarDepto";
            this.btnCancelarDepto.Size = new System.Drawing.Size(177, 38);
            this.btnCancelarDepto.TabIndex = 14;
            this.btnCancelarDepto.Text = "Cancelar";
            this.btnCancelarDepto.UseVisualStyleBackColor = true;
            // 
            // btnGuardarDepto
            // 
            this.btnGuardarDepto.Location = new System.Drawing.Point(0, 62);
            this.btnGuardarDepto.Name = "btnGuardarDepto";
            this.btnGuardarDepto.Size = new System.Drawing.Size(177, 38);
            this.btnGuardarDepto.TabIndex = 13;
            this.btnGuardarDepto.Text = "Guardar Departamento";
            this.btnGuardarDepto.UseVisualStyleBackColor = true;
            // 
            // txtNuevoDepto
            // 
            this.txtNuevoDepto.Location = new System.Drawing.Point(76, 19);
            this.txtNuevoDepto.Name = "txtNuevoDepto";
            this.txtNuevoDepto.Size = new System.Drawing.Size(166, 22);
            this.txtNuevoDepto.TabIndex = 8;
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
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.casaTequileraBarrilitoDataSet1;
            // 
            // casaTequileraBarrilitoDataSet1
            // 
            this.casaTequileraBarrilitoDataSet1.DataSetName = "CasaTequileraBarrilitoDataSet1";
            this.casaTequileraBarrilitoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // casaTequileraBarrilitoDataSet2
            // 
            this.casaTequileraBarrilitoDataSet2.DataSetName = "CasaTequileraBarrilitoDataSet2";
            this.casaTequileraBarrilitoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentosBindingSource1
            // 
            this.departamentosBindingSource1.DataMember = "Departamentos";
            this.departamentosBindingSource1.DataSource = this.casaTequileraBarrilitoDataSet2;
            // 
            // departamentosTableAdapter1
            // 
            this.departamentosTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.AutoGenerateColumns = false;
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepartamentoDataGridViewTextBoxColumn,
            this.nombreDepartamentoDataGridViewTextBoxColumn});
            this.dgvDepartamento.DataSource = this.departamentosBindingSource2;
            this.dgvDepartamento.Location = new System.Drawing.Point(12, 117);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.RowHeadersWidth = 51;
            this.dgvDepartamento.RowTemplate.Height = 24;
            this.dgvDepartamento.Size = new System.Drawing.Size(323, 358);
            this.dgvDepartamento.TabIndex = 11;
            // 
            // casaTequileraBarrilitoDataSet
            // 
            this.casaTequileraBarrilitoDataSet.DataSetName = "CasaTequileraBarrilitoDataSet";
            this.casaTequileraBarrilitoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casaTequileraBarrilitoDataSetBindingSource
            // 
            this.casaTequileraBarrilitoDataSetBindingSource.DataSource = this.casaTequileraBarrilitoDataSet;
            this.casaTequileraBarrilitoDataSetBindingSource.Position = 0;
            // 
            // casaTequileraBarrilitoDataSet3
            // 
            this.casaTequileraBarrilitoDataSet3.DataSetName = "CasaTequileraBarrilitoDataSet3";
            this.casaTequileraBarrilitoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentosBindingSource2
            // 
            this.departamentosBindingSource2.DataMember = "Departamentos";
            this.departamentosBindingSource2.DataSource = this.casaTequileraBarrilitoDataSet3;
            // 
            // departamentosTableAdapter2
            // 
            this.departamentosTableAdapter2.ClearBeforeFill = true;
            // 
            // idDepartamentoDataGridViewTextBoxColumn
            // 
            this.idDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "IdDepartamento";
            this.idDepartamentoDataGridViewTextBoxColumn.HeaderText = "IdDepartamento";
            this.idDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDepartamentoDataGridViewTextBoxColumn.Name = "idDepartamentoDataGridViewTextBoxColumn";
            this.idDepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDepartamentoDataGridViewTextBoxColumn.Visible = false;
            this.idDepartamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDepartamentoDataGridViewTextBoxColumn
            // 
            this.nombreDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "NombreDepartamento";
            this.nombreDepartamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.nombreDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDepartamentoDataGridViewTextBoxColumn.Name = "nombreDepartamentoDataGridViewTextBoxColumn";
            this.nombreDepartamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Departamentos";
            this.Size = new System.Drawing.Size(803, 577);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaTequileraBarrilitoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNuevoDepto;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminarDepto;
        private System.Windows.Forms.Button btnNuevoDepto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private CasaTequileraBarrilitoDataSet1 casaTequileraBarrilitoDataSet1;
        private CasaTequileraBarrilitoDataSet1TableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.Button btnCancelarDepto;
        private System.Windows.Forms.Button btnGuardarDepto;
        private System.Windows.Forms.BindingSource departamentosBindingSource1;
        private CasaTequileraBarrilitoDataSet2 casaTequileraBarrilitoDataSet2;
        private CasaTequileraBarrilitoDataSet2TableAdapters.DepartamentosTableAdapter departamentosTableAdapter1;
        private System.Windows.Forms.DataGridView dgvDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource departamentosBindingSource2;
        private CasaTequileraBarrilitoDataSet3 casaTequileraBarrilitoDataSet3;
        private CasaTequileraBarrilitoDataSet casaTequileraBarrilitoDataSet;
        private System.Windows.Forms.BindingSource casaTequileraBarrilitoDataSetBindingSource;
        private CasaTequileraBarrilitoDataSet3TableAdapters.DepartamentosTableAdapter departamentosTableAdapter2;
    }
}

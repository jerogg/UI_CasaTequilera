namespace CasaTequileraElBarrilito
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.btnOpcionesHab = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpcionesHab
            // 
            this.btnOpcionesHab.Cursor = System.Windows.Forms.Cursors.No;
            this.btnOpcionesHab.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcionesHab.Image")));
            this.btnOpcionesHab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpcionesHab.Location = new System.Drawing.Point(12, 12);
            this.btnOpcionesHab.Name = "btnOpcionesHab";
            this.btnOpcionesHab.Size = new System.Drawing.Size(90, 69);
            this.btnOpcionesHab.TabIndex = 1;
            this.btnOpcionesHab.Text = "Opciones habilitadas";
            this.btnOpcionesHab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpcionesHab.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.No;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuarios.Location = new System.Drawing.Point(108, 12);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(90, 69);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "Base de datos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnOpcionesHab);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpcionesHab;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button button1;
    }
}
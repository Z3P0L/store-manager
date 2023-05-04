namespace Proyecto_POO.Vistas
{
    partial class frmEmpleado
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbProductoTexto = new System.Windows.Forms.GroupBox();
            this.cbDocumentoTipo = new System.Windows.Forms.ComboBox();
            this.lblDocumentoTipo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.gbProductoTexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 46);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbProductoTexto
            // 
            this.gbProductoTexto.Controls.Add(this.cbDocumentoTipo);
            this.gbProductoTexto.Controls.Add(this.lblDocumentoTipo);
            this.gbProductoTexto.Controls.Add(this.lblNombre);
            this.gbProductoTexto.Controls.Add(this.txtNombre);
            this.gbProductoTexto.Controls.Add(this.lblApellido);
            this.gbProductoTexto.Controls.Add(this.txtApellido);
            this.gbProductoTexto.Controls.Add(this.lblDocumento);
            this.gbProductoTexto.Controls.Add(this.txtDocumento);
            this.gbProductoTexto.Location = new System.Drawing.Point(12, 87);
            this.gbProductoTexto.Name = "gbProductoTexto";
            this.gbProductoTexto.Size = new System.Drawing.Size(346, 149);
            this.gbProductoTexto.TabIndex = 15;
            this.gbProductoTexto.TabStop = false;
            this.gbProductoTexto.Text = "Información básica";
            // 
            // cbDocumentoTipo
            // 
            this.cbDocumentoTipo.FormattingEnabled = true;
            this.cbDocumentoTipo.Items.AddRange(new object[] {
            "CC",
            "CE",
            "TI"});
            this.cbDocumentoTipo.Location = new System.Drawing.Point(240, 115);
            this.cbDocumentoTipo.Name = "cbDocumentoTipo";
            this.cbDocumentoTipo.Size = new System.Drawing.Size(100, 21);
            this.cbDocumentoTipo.TabIndex = 11;
            this.cbDocumentoTipo.Text = "Seleccione";
            // 
            // lblDocumentoTipo
            // 
            this.lblDocumentoTipo.AutoSize = true;
            this.lblDocumentoTipo.Location = new System.Drawing.Point(237, 92);
            this.lblDocumentoTipo.Name = "lblDocumentoTipo";
            this.lblDocumentoTipo.Size = new System.Drawing.Size(99, 13);
            this.lblDocumentoTipo.TabIndex = 10;
            this.lblDocumentoTipo.Text = "Tipo de documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(237, 31);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(240, 56);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(6, 92);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 5;
            this.lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(6, 117);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 9;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(236, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(122, 46);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(18, 254);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(68, 13);
            this.lblClave.TabIndex = 12;
            this.lblClave.Text = "Nueva clave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(141, 251);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(217, 20);
            this.txtClave.TabIndex = 12;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 293);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbProductoTexto);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.gbProductoTexto.ResumeLayout(false);
            this.gbProductoTexto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbProductoTexto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumentoTipo;
        private System.Windows.Forms.ComboBox cbDocumentoTipo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
    }
}
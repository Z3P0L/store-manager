namespace Proyecto_POO.Vistas
{
    partial class frmProducto
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.ofdCargarImagen = new System.Windows.Forms.OpenFileDialog();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbProductoTexto = new System.Windows.Forms.GroupBox();
            this.pbProductoImagen = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbProductoTexto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductoImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 46);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(12, 295);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(42, 13);
            this.lblImagen.TabIndex = 3;
            this.lblImagen.Text = "Imagen";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(237, 31);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(6, 92);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(68, 13);
            this.lblPrecioVenta.TabIndex = 5;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(237, 92);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(75, 13);
            this.lblPrecioCompra.TabIndex = 6;
            this.lblPrecioCompra.Text = "Precio compra";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(240, 56);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(6, 117);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 9;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(240, 117);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCompra.TabIndex = 10;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(12, 321);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(103, 35);
            this.btnCargarImagen.TabIndex = 11;
            this.btnCargarImagen.Text = "Cargar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // ofdCargarImagen
            // 
            this.ofdCargarImagen.FileName = "ofdCargarImagen";
            this.ofdCargarImagen.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(18, 95);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Product ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(94, 92);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(258, 20);
            this.txtId.TabIndex = 13;
            // 
            // gbProductoTexto
            // 
            this.gbProductoTexto.Controls.Add(this.lblNombre);
            this.gbProductoTexto.Controls.Add(this.txtNombre);
            this.gbProductoTexto.Controls.Add(this.lblCantidad);
            this.gbProductoTexto.Controls.Add(this.txtCantidad);
            this.gbProductoTexto.Controls.Add(this.txtPrecioCompra);
            this.gbProductoTexto.Controls.Add(this.lblPrecioVenta);
            this.gbProductoTexto.Controls.Add(this.lblPrecioCompra);
            this.gbProductoTexto.Controls.Add(this.txtPrecioVenta);
            this.gbProductoTexto.Location = new System.Drawing.Point(12, 129);
            this.gbProductoTexto.Name = "gbProductoTexto";
            this.gbProductoTexto.Size = new System.Drawing.Size(346, 149);
            this.gbProductoTexto.TabIndex = 14;
            this.gbProductoTexto.TabStop = false;
            this.gbProductoTexto.Text = "Información básica";
            // 
            // pbProductoImagen
            // 
            this.pbProductoImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProductoImagen.Location = new System.Drawing.Point(252, 295);
            this.pbProductoImagen.Name = "pbProductoImagen";
            this.pbProductoImagen.Size = new System.Drawing.Size(100, 61);
            this.pbProductoImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductoImagen.TabIndex = 15;
            this.pbProductoImagen.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(230, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(122, 46);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 366);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pbProductoImagen);
            this.Controls.Add(this.gbProductoTexto);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmProducto";
            this.Text = "Producto";
            this.VisibleChanged += new System.EventHandler(this.frmProducto_VisibleChanged);
            this.gbProductoTexto.ResumeLayout(false);
            this.gbProductoTexto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductoImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.OpenFileDialog ofdCargarImagen;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox gbProductoTexto;
        private System.Windows.Forms.PictureBox pbProductoImagen;
        private System.Windows.Forms.Button btnVolver;
    }
}
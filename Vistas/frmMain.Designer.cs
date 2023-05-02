namespace Proyecto_POO.Vistas
{
    partial class frmMain
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.llblReporsitory = new System.Windows.Forms.LinkLabel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(72, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(115, 20);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Store manager";
            // 
            // btnCaja
            // 
            this.btnCaja.Location = new System.Drawing.Point(16, 106);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(227, 45);
            this.btnCaja.TabIndex = 3;
            this.btnCaja.Text = "Ir a caja";
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(16, 72);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(103, 28);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // llblReporsitory
            // 
            this.llblReporsitory.AutoSize = true;
            this.llblReporsitory.Location = new System.Drawing.Point(16, 13);
            this.llblReporsitory.Name = "llblReporsitory";
            this.llblReporsitory.Size = new System.Drawing.Size(204, 13);
            this.llblReporsitory.TabIndex = 5;
            this.llblReporsitory.TabStop = true;
            this.llblReporsitory.Text = "https://github.com/Z3P0L/store-manager";
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(140, 72);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(103, 28);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 172);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.llblReporsitory);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmMain";
            this.Text = "Interfaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.LinkLabel llblReporsitory;
        private System.Windows.Forms.Button btnProductos;
    }
}
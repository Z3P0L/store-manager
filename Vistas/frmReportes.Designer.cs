namespace Proyecto_POO.Vistas
{
    partial class frmReportes
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
            this.lblTittleUtilidadBruta = new System.Windows.Forms.Label();
            this.lblTitleUtilidadNeta = new System.Windows.Forms.Label();
            this.lblTitleProducto = new System.Windows.Forms.Label();
            this.lblTitleVenta = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUtilidadBruta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUtilidadNeta = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProducto = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblVenta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTittleUtilidadBruta
            // 
            this.lblTittleUtilidadBruta.AutoSize = true;
            this.lblTittleUtilidadBruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittleUtilidadBruta.Location = new System.Drawing.Point(12, 137);
            this.lblTittleUtilidadBruta.Name = "lblTittleUtilidadBruta";
            this.lblTittleUtilidadBruta.Size = new System.Drawing.Size(141, 25);
            this.lblTittleUtilidadBruta.TabIndex = 0;
            this.lblTittleUtilidadBruta.Text = "Utilidad Bruta";
            // 
            // lblTitleUtilidadNeta
            // 
            this.lblTitleUtilidadNeta.AutoSize = true;
            this.lblTitleUtilidadNeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUtilidadNeta.Location = new System.Drawing.Point(318, 137);
            this.lblTitleUtilidadNeta.Name = "lblTitleUtilidadNeta";
            this.lblTitleUtilidadNeta.Size = new System.Drawing.Size(135, 25);
            this.lblTitleUtilidadNeta.TabIndex = 1;
            this.lblTitleUtilidadNeta.Text = "Utilidad Neta";
            // 
            // lblTitleProducto
            // 
            this.lblTitleProducto.AutoSize = true;
            this.lblTitleProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleProducto.Location = new System.Drawing.Point(12, 241);
            this.lblTitleProducto.Name = "lblTitleProducto";
            this.lblTitleProducto.Size = new System.Drawing.Size(226, 25);
            this.lblTitleProducto.TabIndex = 2;
            this.lblTitleProducto.Text = "Producto más vendido";
            // 
            // lblTitleVenta
            // 
            this.lblTitleVenta.AutoSize = true;
            this.lblTitleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleVenta.Location = new System.Drawing.Point(318, 241);
            this.lblTitleVenta.Name = "lblTitleVenta";
            this.lblTitleVenta.Size = new System.Drawing.Size(187, 25);
            this.lblTitleVenta.TabIndex = 3;
            this.lblTitleVenta.Text = "Venta más grande";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(15, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(122, 46);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUtilidadBruta);
            this.panel1.Location = new System.Drawing.Point(17, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 47);
            this.panel1.TabIndex = 20;
            // 
            // lblUtilidadBruta
            // 
            this.lblUtilidadBruta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUtilidadBruta.Location = new System.Drawing.Point(0, 0);
            this.lblUtilidadBruta.Name = "lblUtilidadBruta";
            this.lblUtilidadBruta.Size = new System.Drawing.Size(136, 47);
            this.lblUtilidadBruta.TabIndex = 0;
            this.lblUtilidadBruta.Text = "0";
            this.lblUtilidadBruta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUtilidadNeta);
            this.panel2.Location = new System.Drawing.Point(323, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 47);
            this.panel2.TabIndex = 21;
            // 
            // lblUtilidadNeta
            // 
            this.lblUtilidadNeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUtilidadNeta.Location = new System.Drawing.Point(0, 0);
            this.lblUtilidadNeta.Name = "lblUtilidadNeta";
            this.lblUtilidadNeta.Size = new System.Drawing.Size(136, 47);
            this.lblUtilidadNeta.TabIndex = 0;
            this.lblUtilidadNeta.Text = "0";
            this.lblUtilidadNeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblProducto);
            this.panel3.Location = new System.Drawing.Point(20, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 47);
            this.panel3.TabIndex = 22;
            // 
            // lblProducto
            // 
            this.lblProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProducto.Location = new System.Drawing.Point(0, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(136, 47);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "0";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblVenta);
            this.panel4.Location = new System.Drawing.Point(326, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 47);
            this.panel4.TabIndex = 23;
            // 
            // lblVenta
            // 
            this.lblVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVenta.Location = new System.Drawing.Point(0, 0);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(136, 47);
            this.lblVenta.TabIndex = 0;
            this.lblVenta.Text = "0";
            this.lblVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(83, 72);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 24;
            this.lblDesde.Text = "Desde";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(12, 94);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(215, 20);
            this.dtpDesde.TabIndex = 25;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(290, 94);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(215, 20);
            this.dtpHasta.TabIndex = 26;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(377, 72);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 27;
            this.lblHasta.Text = "Hasta";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 336);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitleVenta);
            this.Controls.Add(this.lblTitleProducto);
            this.Controls.Add(this.lblTitleUtilidadNeta);
            this.Controls.Add(this.lblTittleUtilidadBruta);
            this.Name = "frmReportes";
            this.Text = "Reportes";
            this.VisibleChanged += new System.EventHandler(this.frmReportes_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittleUtilidadBruta;
        private System.Windows.Forms.Label lblTitleUtilidadNeta;
        private System.Windows.Forms.Label lblTitleProducto;
        private System.Windows.Forms.Label lblTitleVenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUtilidadBruta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUtilidadNeta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
    }
}
﻿using Proyecto_POO.Clases;
using System;
using System.Windows.Forms;

namespace Proyecto_POO.Vistas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            if (GlobalVars.UserType != "admin")
            {
                btnUsuarios.Visible = false;
                btnReportes.Visible = false;
                btnProductos.Visible = false;
                this.btnCaja.Location = new System.Drawing.Point(16, 72);
                this.ClientSize = new System.Drawing.Size(255, 133);
            }
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            frmCaja caja = new frmCaja();
            caja.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.Show();
            this.Hide();
        }

        private void llblReporsitory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Z3P0L/store-manager");
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes reportes = new frmReportes();
            reportes.Show();
            this.Hide();
        }

        private void frmMain_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible) GlobalVars.LastForm = this;
        }
    }
}

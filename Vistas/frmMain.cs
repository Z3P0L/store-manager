using Proyecto_POO.Clases;
using System;
using System.Windows.Forms;

namespace Proyecto_POO.Vistas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            if (GlobalVars.GlobalUserLogged == null)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
            InitializeComponent();
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
    }
}

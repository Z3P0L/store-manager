using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO.Clases;

namespace Proyecto_POO.Vistas
{
    public partial class frmProducto : Form
    {
        database cn;
        SqlCommand cmd;
        string imgRoute = "";
        public frmProducto()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            if (ofdCargarImagen.ShowDialog() == DialogResult.OK)
            {
                imgRoute = ofdCargarImagen.FileName;
                pbProductoImagen.Image = new Bitmap(ofdCargarImagen.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.Show();
            this.Hide();
        }
    }
}

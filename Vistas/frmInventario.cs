using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using Proyecto_POO.Clases;

namespace Proyecto_POO.Vistas
{
    public partial class frmInventario : Form
    {
        database cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public frmInventario()
        {
            InitializeComponent();
            dataGridViewDesign();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            frmProducto producto = new frmProducto();
            producto.Show();
            this.Hide();
        }
    }
}

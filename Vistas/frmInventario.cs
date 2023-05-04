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

            cn = new database();
            LoadProducts();
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

        private void LoadProducts()
        {
            dt = cn.GetAll("productos");

            foreach (DataRow dr in dt.Rows)
            {
                dgvProductos.Rows.Add(dr["nombre"], Image.FromFile(dr["imagen"].ToString()), dr["cantidad"], dr["precio_venta"]);
            }
        }
    }
}

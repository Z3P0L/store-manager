using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proyecto_POO.Clases;

namespace Proyecto_POO.Vistas
{
    public partial class frmInventario : Form
    {
        database cn;
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
                dgvProductos.Rows.Add(dr["Id"], dr["nombre"], Image.FromFile(dr["imagen"].ToString()), dr["cantidad"], dr["precio_venta"], "Editar", "Eliminar");
            }
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int productId = (int)dgvProductos.Rows[e.RowIndex].Cells["Id"].Value;

            if (e.ColumnIndex == dgvProductos.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                GlobalVars.GlobalId = productId;
                frmProducto producto = new frmProducto();
                producto.Show();
                this.Hide();
            }

            if (e.ColumnIndex == dgvProductos.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el producto " + dgvProductos.Rows[e.RowIndex].Cells["nombre"].Value + "?", "Confirmar eliminación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string sql = "DELETE FROM productos WHERE Id=" + productId;
                    cn.Query(sql);
                    MessageBox.Show("Producto eliminado exitosamente.");

                    dgvProductos.Rows.Clear();
                    LoadProducts();
                }
            }
        }
    }
}

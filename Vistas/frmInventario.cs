using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
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
                    string sql = "DELETE FROM productos WHERE Id = @Id";
                    List<SqlParameter> parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@Id", productId)
                    };
                    cn.Query(sql, parameters);
                    MessageBox.Show("Producto eliminado exitosamente.");

                    dgvProductos.Rows.Clear();
                    LoadProducts();
                }
            }
        }

        private void frmInventario_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible) GlobalVars.LastForm = this;
        }
    }
}

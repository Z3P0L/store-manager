using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_POO.Clases;

namespace Proyecto_POO.Vistas
{
    public partial class frmCaja : Form
    {
        database cn;
        DataTable dt;
        public frmCaja()
        {
            InitializeComponent();
            dataGridViewDesign();

            cn = new database();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataRow producto = cn.GetById("productos", Int32.Parse(txtProductoId.Text));
            if (producto == null) 
            {
                MessageBox.Show("El producto no existe.");
                return;
            }

            int cantidadDb = Int32.Parse(producto["cantidad"].ToString());
            int cantidadFrm = Int32.Parse(txtCantidad.Text);

            if (cantidadFrm <= 0)
            {
                MessageBox.Show("La cantidad debe ser superior a 0.");
                return;
            }
            if (cantidadFrm > cantidadDb)
            {
                MessageBox.Show("Aviso: La cantidad es superior al stock (" + cantidadDb + ").");
                return;
            }

            dgvProductos.Rows.Add(producto["Id"].ToString(), producto["nombre"].ToString(), Image.FromFile(producto["imagen"].ToString()), cantidadFrm, producto["precio_venta"].ToString(), "Remover");
            calcTotal();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProductos.Columns["Acción"].Index && e.RowIndex >= 0)
            {
                dgvProductos.Rows.RemoveAt(e.RowIndex);
            }
            calcTotal();
        }

        private double calcTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                double precio = Convert.ToDouble(row.Cells["Precio"].Value);
                double precioTotal = cantidad * precio;
                total += precioTotal;
            }
            lblTotal.Text = total.ToString("C2");

            return total;
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.Date;
            float total = (float)calcTotal();

            string sql = "INSERT INTO ventas(usuario, fecha, total) VALUES(@usuario, @fecha, @total)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@usuario", Int32.Parse(GlobalVars.GlobalUserLogged)),
                new SqlParameter("@fecha", fecha.ToString("dd/MM/yyyy")),
                new SqlParameter("@total", total)
            };
            cn.Query(sql, parameters);

            sql = "SELECT TOP 1 Id FROM ventas ORDER BY Id DESC;";
            dt = cn.Query(sql);
            int ventaId = Convert.ToInt32(dt.Rows[0]["Id"]);

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                int productoId = Convert.ToInt32(row.Cells["Id"].Value);
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                sql = "INSERT INTO ventas_productos (Id, producto, cantidad) VALUES (@Id, @producto, @cantidad)";
                parameters.Clear();
                parameters.Add(new SqlParameter("@Id", ventaId));
                parameters.Add(new SqlParameter("@producto", productoId));
                parameters.Add(new SqlParameter("@cantidad", cantidad));
                cn.Query(sql, parameters);

                sql = "UPDATE productos SET cantidad = @cantidad WHERE Id = @Id";
                parameters.Clear();
                parameters.Add(new SqlParameter("@cantidad", cantidad));
                parameters.Add(new SqlParameter("@Id", productoId));
                cn.Query(sql, parameters);
            }

            dgvProductos.Rows.Clear();
            lblTotal.Text = 0.ToString("C2");
        }
    }
}

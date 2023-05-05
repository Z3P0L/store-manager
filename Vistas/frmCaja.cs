using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void calcTotal()
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
        }
    }
}

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
            if (Int32.Parse(txtCantidad.Text) <= 0)
            {
                MessageBox.Show("La cantidad debe ser superior a 0.");
                return;
            }
            if (Int32.Parse(txtCantidad.Text) > Int32.Parse(producto["cantidad"].ToString()))
            {
                MessageBox.Show("Aviso: La cantidad es superior al stock (" + producto["cantidad"].ToString() + ").");
                return;
            }
            dgvProductos.Rows.Add(producto["Id"].ToString(), producto["nombre"].ToString(), Image.FromFile(producto["imagen"].ToString()), txtCantidad.Text, producto["precio_venta"].ToString(), "Remover");
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

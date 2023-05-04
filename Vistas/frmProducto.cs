using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            cn = new database();
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            if (ofdCargarImagen.ShowDialog() == DialogResult.OK)
            {
                imgRoute = ofdCargarImagen.FileName;
                try
                {
                    pbProductoImagen.Image = new Bitmap(ofdCargarImagen.FileName);
                } catch
                {
                    imgRoute = "";
                    MessageBox.Show("Hubo un error cargando la imagen, por favor intente con otra.");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id, cantidad;
            float precioCompra, precioVenta;

            try
            {
                id = Int32.Parse(txtId.Text);
                cantidad = Int32.Parse(txtCantidad.Text);
                precioCompra = float.Parse(txtPrecioCompra.Text, CultureInfo.InvariantCulture);
                precioVenta = float.Parse(txtPrecioVenta.Text, CultureInfo.InvariantCulture);                
            } catch
            {
                MessageBox.Show("No se pudo guardar el producto. Verifique que los campos tengan los valores adecuados.");
                return;
            }

            if (imgRoute.Equals(""))
            {
                MessageBox.Show("Agregue una imagen antes de guardar");
                return;
            }

            string sql = "INSERT INTO productos(Id, nombre, imagen, cantidad, precio_compra, precio_venta) VALUES(@Id, @nombre, @imagen, @cantidad, @precio_compra, @precio_venta)";
            cmd = new SqlCommand(sql, cn.OpenConnection());
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@imagen", imgRoute);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@precio_compra", precioCompra);
            cmd.Parameters.AddWithValue("@precio_venta", precioVenta);
            cmd.ExecuteNonQuery();

            txtCantidad.Clear();
            txtId.Clear();
            txtNombre.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            MessageBox.Show("Producto guardado exitosamente.");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.Show();
            this.Hide();
        }

        private bool getGlobalId()
        {
            if (GlobalVars.GlobalId.ToString() == null) return false;
            return true;
        }
    }
}

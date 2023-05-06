using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Proyecto_POO.Clases;

namespace Proyecto_POO.Vistas
{
    public partial class frmProducto : Form
    {
        database cn;
        string imgRoute = "";
        public frmProducto()
        {
            cn = new database();
            InitializeComponent();

            if (getGlobalId())
            {
                DataRow producto = cn.GetById("productos", GlobalVars.GlobalId);
                if (producto != null)
                {
                    txtId.Text = producto["Id"].ToString();
                    txtId.Enabled = false;
                    txtNombre.Text = producto["nombre"].ToString();
                    txtCantidad.Text = producto["cantidad"].ToString();
                    txtPrecioCompra.Text = producto["precio_compra"].ToString();
                    txtPrecioVenta.Text = producto["precio_venta"].ToString();
                    imgRoute = producto["imagen"].ToString();
                    pbProductoImagen.Image = new Bitmap(imgRoute);
                }
            }
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
            string sql;

            try
            {
                id = Int32.Parse(txtId.Text);
                cantidad = Int32.Parse(txtCantidad.Text);
                precioCompra = float.Parse(txtPrecioCompra.Text, CultureInfo.InvariantCulture);
                precioVenta = float.Parse(txtPrecioVenta.Text, CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("No se pudo guardar el producto. Verifique que los campos tengan los valores adecuados.");
                return;
            }

            if (imgRoute.Equals(""))
            {
                MessageBox.Show("Agregue una imagen antes de guardar");
                return;
            }

            DataRow producto = cn.GetById("productos", Int32.Parse(txtId.Text));
            if (producto == null)
            {
                sql = "INSERT INTO productos(Id, nombre, imagen, cantidad, precio_compra, precio_venta) VALUES(@Id, @nombre, @imagen, @cantidad, @precio_compra, @precio_venta)";
            } else
            {
                sql = "UPDATE productos SET Id=@Id, nombre=@nombre, imagen=@imagen, cantidad=@cantidad, precio_compra=@precio_compra, precio_venta=@precio_venta WHERE Id = GlobalId";
            }
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@nombre", txtNombre.Text),
                new SqlParameter("@imagen", imgRoute),
                new SqlParameter("@cantidad", cantidad),
                new SqlParameter("@precio_compra", precioCompra),
                new SqlParameter("@precio_venta", precioVenta),
                new SqlParameter("@GlobalDocumento", GlobalVars.GlobalId)

            };
            cn.Query(sql, parameters);

            GlobalVars.GlobalId = -1;
            txtCantidad.Clear();
            txtId.Clear();
            txtNombre.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            imgRoute = "";
            pbProductoImagen.Image = null;
            MessageBox.Show("Producto guardado exitosamente.");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            GlobalVars.GlobalId = -1;
            GlobalVars.LastForm.Show();
            this.Hide();
        }

        private bool getGlobalId()
        {
            if (GlobalVars.GlobalId == -1) return false;
            return true;
        }

        private void frmProducto_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible) GlobalVars.LastForm = this;
        }
    }
}

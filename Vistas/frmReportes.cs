using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto_POO.Clases;

namespace Proyecto_POO.Vistas
{
    public partial class frmReportes : Form
    {
        database cn;
        DataTable dt;
        public frmReportes()
        {
            InitializeComponent();
            cn = new database();
            Init();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            GlobalVars.LastForm.Show();
            this.Hide();
        }

        private void getUtilidadBruta()
        {
            string sql = "SELECT SUM(vp.cantidad * p.precio_venta) AS utilidad_bruta FROM ventas v INNER JOIN ventas_productos vp ON v.Id = vp.Id INNER JOIN productos p ON vp.producto = p.Id";

            dt = new DataTable();
            dt = cn.Query(sql);
            float utilidadBrutaTotal = Convert.ToSingle(dt.Rows[0]["utilidad_bruta"]);

            lblUtilidadBruta.Text = utilidadBrutaTotal.ToString("C2");
        }

        private void getUtilidadNeta()
        {
            string sql = "SELECT SUM(vp.cantidad * (p.precio_venta - p.precio_compra)) AS utilidad_neta FROM ventas v INNER JOIN ventas_productos vp ON v.Id = vp.Id INNER JOIN productos p ON vp.producto = p.Id";

            dt = new DataTable();
            dt = cn.Query(sql);
            float utilidadNetaTotal = Convert.ToSingle(dt.Rows[0]["utilidad_neta"]);

            lblUtilidadNeta.Text = utilidadNetaTotal.ToString("C2");
        }

        private void getProductoMasVendido()
        {
            string sql = "SELECT TOP 1 p.nombre, SUM(vp.cantidad) AS total_vendido FROM ventas v INNER JOIN ventas_productos vp ON v.Id = vp.Id INNER JOIN productos p ON vp.producto = p.Id GROUP BY p.nombre ORDER BY total_vendido DESC";
            dt = new DataTable();
            dt = cn.Query(sql);
            lblProducto.Text = dt.Rows[0]["nombre"].ToString() + "(" + dt.Rows[0]["total_vendido"] + ")";
        }

        private void getVentaMasGrande()
        {
            string sql = "SELECT TOP 1 total, COUNT(*) AS cantidad FROM ventas GROUP BY total ORDER BY total DESC";
            dt = new DataTable();
            dt = cn.Query(sql);
            lblVenta.Text = dt.Rows[0]["total"].ToString() + " (" + dt.Rows[0]["cantidad"].ToString() + ")";
        }

        private void Init()
        {
            getUtilidadBruta();
            getUtilidadNeta();
            getProductoMasVendido();
            getVentaMasGrande();
        }

        private void frmReportes_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible) GlobalVars.LastForm = this;
        }
    }
}

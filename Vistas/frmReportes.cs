using System;
using System.Collections.Generic;
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
            string sql = "SELECT SUM(vp.cantidad * p.precio_venta) AS utilidad_bruta FROM ventas v INNER JOIN ventas_productos vp ON v.Id = vp.Id INNER JOIN productos p ON vp.producto = p.Id WHERE v.fecha BETWEEN @desde AND @hasta";
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            dt = new DataTable();
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@desde", desde.Date.ToString("yyyy-MM-dd")),
                new SqlParameter("@hasta", hasta.Date.ToString("yyyy-MM-dd"))
            };
            dt = cn.Query(sql, parameters);
            if (!DBNull.Value.Equals(dt.Rows[0]["utilidad_bruta"]))
            {
                float utilidadBrutaTotal = Convert.ToSingle(dt.Rows[0]["utilidad_bruta"]);
                lblUtilidadBruta.Text = utilidadBrutaTotal.ToString("C2");
            }
        }

        private void getUtilidadNeta()
        {
            string sql = "SELECT SUM(vp.cantidad * (p.precio_venta - p.precio_compra)) AS utilidad_neta FROM ventas v INNER JOIN ventas_productos vp ON v.Id = vp.Id INNER JOIN productos p ON vp.producto = p.Id WHERE v.fecha BETWEEN @desde AND @hasta";
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            dt = new DataTable();
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@desde", desde.Date.ToString("yyyy-MM-dd")),
                new SqlParameter("@hasta", hasta.Date.ToString("yyyy-MM-dd"))
            };
            dt = cn.Query(sql, parameters);
            if (!DBNull.Value.Equals(dt.Rows[0]["utilidad_neta"]))
            {
                float utilidadNetaTotal = Convert.ToSingle(dt.Rows[0]["utilidad_neta"]);
                lblUtilidadNeta.Text = utilidadNetaTotal.ToString("C2");
            }
        }

        private void getProductoMasVendido()
        {
            string sql = "SELECT TOP 1 p.nombre, SUM(vp.cantidad) AS total_vendido FROM ventas v INNER JOIN ventas_productos vp ON v.Id = vp.Id INNER JOIN productos p ON vp.producto = p.Id WHERE v.fecha BETWEEN @desde AND @hasta GROUP BY p.nombre ORDER BY total_vendido DESC";
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            dt = new DataTable();
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@desde", desde.Date.ToString("yyyy-MM-dd")),
                new SqlParameter("@hasta", hasta.Date.ToString("yyyy-MM-dd"))
            };
            dt = cn.Query(sql, parameters);
            if (dt.Rows.Count > 0)
            {
                lblProducto.Text = dt.Rows[0]["nombre"].ToString() + "(" + dt.Rows[0]["total_vendido"] + ")";
            }
        }

        private void getVentaMasGrande()
        {
            string sql = "SELECT TOP 1 total, COUNT(*) AS cantidad FROM ventas WHERE fecha BETWEEN @desde AND @hasta GROUP BY total ORDER BY total DESC";
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            dt = new DataTable();
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@desde", desde.Date.ToString("yyyy-MM-dd")),
                new SqlParameter("@hasta", hasta.Date.ToString("yyyy-MM-dd"))
            };
            dt = cn.Query(sql, parameters);
            if (dt.Rows.Count > 0)
            {
                lblVenta.Text = dt.Rows[0]["total"].ToString() + " (" + dt.Rows[0]["cantidad"].ToString() + ")";
            }
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

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            Init();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            Init();
        }
    }
}

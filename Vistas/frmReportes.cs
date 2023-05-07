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
            GenerarReporte();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            GlobalVars.LastForm.Show();
            this.Hide();
        }

        private void GenerarReporte()
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;

            string utilidadBrutaSql = "SELECT SUM(vp.cantidad * p.precio_venta) AS utilidad_bruta FROM ventas v INNER JOIN ventas_productos vp ON v.Id = vp.Id INNER JOIN productos p ON vp.producto = p.Id WHERE v.fecha BETWEEN @desde AND @hasta";
            string utilidadNetaSql = "SELECT SUM(vp.cantidad * (p.precio_venta - p.precio_compra)) AS utilidad_neta FROM ventas v INNER JOIN ventas_productos vp ON v.Id = vp.Id INNER JOIN productos p ON vp.producto = p.Id WHERE v.fecha BETWEEN @desde AND @hasta";
            string productoMasVendidoSql = "SELECT TOP 1 p.nombre, SUM(vp.cantidad) AS total_vendido FROM ventas v INNER JOIN ventas_productos vp ON v.Id = vp.Id INNER JOIN productos p ON vp.producto = p.Id WHERE v.fecha BETWEEN @desde AND @hasta GROUP BY p.nombre ORDER BY total_vendido DESC";
            string ventaMasGrandeSql = "SELECT TOP 1 total, COUNT(*) AS cantidad FROM ventas WHERE fecha BETWEEN @desde AND @hasta GROUP BY total ORDER BY total DESC";

            DataTable utilidadBrutaDt = cn.Query(utilidadBrutaSql, new List<SqlParameter>
            {
                new SqlParameter("@desde", desde.Date.ToString("yyyy-MM-dd")),
                new SqlParameter("@hasta", hasta.Date.ToString("yyyy-MM-dd"))
            });

            DataTable utilidadNetaDt = cn.Query(utilidadNetaSql, new List<SqlParameter>
            {
                new SqlParameter("@desde", desde.Date.ToString("yyyy-MM-dd")),
                new SqlParameter("@hasta", hasta.Date.ToString("yyyy-MM-dd"))
            });

            DataTable productoMasVendidoDt = cn.Query(productoMasVendidoSql, new List<SqlParameter>
            {
                new SqlParameter("@desde", desde.Date.ToString("yyyy-MM-dd")),
                new SqlParameter("@hasta", hasta.Date.ToString("yyyy-MM-dd"))
            });

            DataTable ventaMasGrandeDt = cn.Query(ventaMasGrandeSql, new List<SqlParameter>
            {
                new SqlParameter("@desde", desde.Date.ToString("yyyy-MM-dd")),
                new SqlParameter("@hasta", hasta.Date.ToString("yyyy-MM-dd"))
            });

            string utilidadBruta = "Sin registros.";
            if (!DBNull.Value.Equals(utilidadBrutaDt.Rows[0]["utilidad_bruta"]))
            {
                float utilidadBrutaTotal = Convert.ToSingle(utilidadBrutaDt.Rows[0]["utilidad_bruta"]);
                utilidadBruta = utilidadBrutaTotal.ToString("C2");
            }

            string utilidadNeta = "Sin registros.";
            if (!DBNull.Value.Equals(utilidadNetaDt.Rows[0]["utilidad_neta"]))
            {
                float utilidadNetaTotal = Convert.ToSingle(utilidadNetaDt.Rows[0]["utilidad_neta"]);
                utilidadNeta = utilidadNetaTotal.ToString("C2");
            }

            string productoMasVendido = "Sin registros.";
            if (productoMasVendidoDt.Rows.Count > 0)
            {
                productoMasVendido = productoMasVendidoDt.Rows[0]["nombre"].ToString() + "(" + productoMasVendidoDt.Rows[0]["total_vendido"] + ")";
            }

            string ventaMasGrande = "Sin registros.";
            if (ventaMasGrandeDt.Rows.Count > 0)
            {
                ventaMasGrande = ventaMasGrandeDt.Rows[0]["total"].ToString() + " (" + ventaMasGrandeDt.Rows[0]["cantidad"].ToString() + ")";
            }

            lblUtilidadBruta.Text = utilidadBruta;
            lblUtilidadNeta.Text = utilidadNeta;
            lblProducto.Text = productoMasVendido;
            lblVenta.Text = ventaMasGrande;
        }

        private void frmReportes_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible) GlobalVars.LastForm = this;
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            GenerarReporte();
        }
    }
}

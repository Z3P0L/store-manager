using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO.Clases;

namespace Proyecto_POO.Vistas
{
    public partial class frmEmpleado : Form
    {
        database cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public frmEmpleado()
        {
            InitializeComponent();
            cn = new database();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        public bool getGlobalDocumento()
        {
            if (GlobalVars.GlobalDocumento.ToString() == null) return false;
            return true;
        }

        public DataRow getUsuario()
        {
            string sql = "SELECT * FROM usuarios WHERE documento=@documento";
            cmd = new SqlCommand(sql, cn.OpenConnection());
            cmd.Parameters.AddWithValue("@documento", GlobalVars.GlobalDocumento);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            return dt.Rows[0];
        }
    }
}

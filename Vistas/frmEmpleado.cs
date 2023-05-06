using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto_POO.Clases;

namespace Proyecto_POO.Vistas
{
    public partial class frmEmpleado : Form
    {
        database cn;
        DataTable dt;
        public frmEmpleado()
        {
            InitializeComponent();
            cn = new database();

            if (getGlobalDocumento())
            {
                DataRow usuario = getUsuario();
                txtDocumento.Text = usuario["documento"].ToString();
                cbDocumentoTipo.Text = usuario["documento_tipo"].ToString();
                txtNombre.Text = usuario["nombre"].ToString();
                txtApellido.Text = usuario["apellido"].ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sql;
            string scrambledPassword = null;
            if (txtClave.Text.Length > 0)
            {
                scrambledPassword = Scrambler.ScramblePassword(txtClave.Text);
                sql = "UPDATE usuarios SET documento=@documento, documento_tipo=@documento_tipo, clave=@clave, nombre=@nombre, apellido=@apellido WHERE documento = @GlobalDocumento";
            } else
            {
                sql = "UPDATE usuarios SET documento=@documento, documento_tipo=@documento_tipo, nombre=@nombre, apellido=@apellido WHERE documento = @GlobalDocumento";
            }
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@documento", txtDocumento.Text),
                new SqlParameter("@documento_tipo", cbDocumentoTipo.Text),
                new SqlParameter("@nombre", txtNombre.Text),
                new SqlParameter("@apellido", txtApellido.Text),
                new SqlParameter("@GlobalDocumento", GlobalVars.GlobalDocumento)
            };
            if (scrambledPassword != null) parameters.Add(new SqlParameter("@clave", scrambledPassword));
            cn.Query(sql, parameters);

            MessageBox.Show("Información guardada exitosamente.");
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
            string sql = "SELECT * FROM usuarios WHERE documento = @documento";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@documento", GlobalVars.GlobalDocumento)
            };

            dt = cn.Query(sql, parameters);

            return dt.Rows[0];
        }
    }
}

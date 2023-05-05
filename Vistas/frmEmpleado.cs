using System;
using System.Data;
using System.Data.SqlClient;
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
                sql = "UPDATE usuarios SET documento=@documento, documento_tipo=@documento_tipo, clave=@clave, nombre=@nombre, apellido=@apellido WHERE documento=" + GlobalVars.GlobalDocumento;
            } else
            {
                sql = "UPDATE usuarios SET documento=@documento, documento_tipo=@documento_tipo, nombre=@nombre, apellido=@apellido WHERE documento=" + GlobalVars.GlobalDocumento;
            }

            cmd = new SqlCommand(sql, cn.OpenConnection());
            cmd.Parameters.AddWithValue("documento", txtDocumento.Text);
            cmd.Parameters.AddWithValue("documento_tipo", cbDocumentoTipo.Text);
            cmd.Parameters.AddWithValue("nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("apellido", txtApellido.Text);
            if (scrambledPassword != null) cmd.Parameters.AddWithValue("clave", scrambledPassword);
            cmd.ExecuteNonQuery();

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

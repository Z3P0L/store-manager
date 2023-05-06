using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto_POO.Clases;

namespace Proyecto_POO.Vistas
{
    public partial class frmLogin : Form
    {
        database cn;
        DataTable dt;
        int count = 0;
        public frmLogin()
        {
            InitializeComponent();
            cn = new database();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string password = Scrambler.ScramblePassword(txtClave.Text);
            string sql = "SELECT * FROM usuarios WHERE documento = @documento AND clave = @clave";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@documento", txtUsuario.Text),
                new SqlParameter("@clave", password)
            };
            dt = cn.Query(sql, parameters);

            if ( dt.Rows.Count <= 0 )
            {
                MessageBox.Show( "Usuario o contraseña incorrectos." );
                txtUsuario.Clear();
                txtClave.Clear();
                count++;

                if ( count > 3 )
                {
                    MessageBox.Show( "Cerrando la aplicación por máximo de intentos permitidos." );
                    this.Close();
                }
            } else {
                GlobalVars.GlobalUserLogged = txtUsuario.Text;
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }
    }
}

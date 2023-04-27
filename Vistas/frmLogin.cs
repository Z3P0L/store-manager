﻿using System;
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
using Proyecto_POO.Vistas;

namespace Proyecto_POO.Vistas
{
    public partial class frmLogin : Form
    {
        database cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int count = 0;
        public frmLogin()
        {
            InitializeComponent();
            cn = new database();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand( "SELECT * FROM usuarios WHERE documento = '" + txtUsuario.Text + "' AND clave = '" + txtClave.Text + "'", cn.OpenConnection() );
            da = new SqlDataAdapter( cmd );
            dt = new DataTable();
            da.Fill( dt );

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
                string usuarioLogged = txtUsuario.Text;
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

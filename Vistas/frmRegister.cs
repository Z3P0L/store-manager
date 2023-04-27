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
using Proyecto_POO.Vistas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Proyecto_POO.Vistas
{
    public partial class frmRegister : Form
    {
        database cn;
        SqlCommand cmd;
        public frmRegister()
        {
            InitializeComponent();
            cn = new database();
            cmbTipoDocumento.SelectedIndex = 0;
            dtpNacimiento.Value = DateTime.Now.AddYears(-17);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtDocumento.Text) || cmbTipoDocumento.SelectedIndex == -1 || dtpNacimiento.Value == null)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            DateTime fechaNacimiento = dtpNacimiento.Value;
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (edad < 17 || edad > 70)
            {
                MessageBox.Show("La edad del usuario debe estar entre 17 y 70 años.");
                return;
            }

            DateTime fecha = dtpNacimiento.Value.Date;
            string sql = "INSERT INTO usuarios(documento, documento_tipo, clave, nombre, apellido, nacimiento) VALUES(@documento, @tipo_documento, @clave, @nombre, @apellido, @nacimiento)";
            cmd = new SqlCommand(sql, cn.OpenConnection());
            cmd.Parameters.AddWithValue("@documento", txtDocumento.Text);
            cmd.Parameters.AddWithValue("@tipo_documento", cmbTipoDocumento.Text);
            cmd.Parameters.AddWithValue("@clave", txtDocumento.Text);
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
            cmd.Parameters.AddWithValue("@nacimiento", fecha);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro exitoso");

            DialogResult result = MessageBox.Show("¿Desea agregar otro usuario?", "Agregar Usuario", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                txtDocumento.Text = "";
                cmbTipoDocumento.SelectedIndex = 0;
                txtNombre.Text = "";
                txtApellido.Text = "";
                dtpNacimiento.Value = DateTime.Now.AddYears(-17);
            }
            else
            {
                this.Close();
            }
        }
    }
}

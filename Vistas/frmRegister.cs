using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto_POO.Clases;

namespace Proyecto_POO.Vistas
{
    public partial class frmRegister : Form
    {
        database cn;
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
            string password = txtContrasena.Text;
            string scrambledPassword = Scrambler.ScramblePassword(password);

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
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@documento", txtDocumento.Text),
                new SqlParameter("@tipo_documento", cmbTipoDocumento.Text),
                new SqlParameter("@clave", scrambledPassword),
                new SqlParameter("@nombre", txtNombre.Text),
                new SqlParameter("@apellido", txtApellido.Text),
                new SqlParameter("@nacimiento", fecha)
            };
            cn.Query(sql, parameters);
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
                frmMain main = new frmMain();
                main.Show();
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            GlobalVars.LastForm.Show();
            this.Hide();
        }

        private void frmRegister_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible) GlobalVars.LastForm = this;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO.Clases;

namespace Proyecto_POO.Vistas
{
    public partial class frmEmpleados : Form
    {
        database cn;
        DataTable dt;
        public frmEmpleados()
        {
            InitializeComponent();
            dataGridViewDesign();

            cn = new database();
            LoadUsuarios();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            frmRegister registro = new frmRegister();
            registro.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void LoadUsuarios()
        {
            dt = cn.GetAll("usuarios");

            foreach (DataRow dr in dt.Rows)
            {
                dgvEmpleados.Rows.Add(dr["documento"], dr["documento_tipo"], dr["nombre"], dr["apellido"], "Editar", "Eliminar");
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int userId = (int)dgvEmpleados.Rows[e.RowIndex].Cells["Id"].Value;

            if (e.ColumnIndex == dgvEmpleados.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                GlobalVars.GlobalDocumento = userId;
                frmProducto producto = new frmProducto();
                producto.Show();
                this.Hide();
            }

            if (e.ColumnIndex == dgvEmpleados.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el empleado " + dgvEmpleados.Rows[e.RowIndex].Cells["nombre"].Value + "?", "Confirmar eliminación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string sql = "DELETE FROM usuarios WHERE documento=" + userId;
                    cn.Query(sql);
                    MessageBox.Show("Empleado eliminado exitosamente.");

                    dgvEmpleados.Rows.Clear();
                    LoadUsuarios();
                }
            }
        }
    }
}

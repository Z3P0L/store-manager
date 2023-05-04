using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO.Vistas
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
            dataGridViewDesign();
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
    }
}

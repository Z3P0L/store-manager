using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proyecto_POO.Vistas
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();

            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add(new DataGridViewImageColumn() { Name = "Imagen", HeaderText = "Imagen", ImageLayout = DataGridViewImageCellLayout.Stretch });
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add(new DataGridViewButtonColumn() { Name = "Editar", HeaderText = "Editar" });
            dgvProductos.Columns.Add(new DataGridViewButtonColumn() { Name = "Eliminar", HeaderText = "Eliminar" });

            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ReadOnly = true;
            dgvProductos.RowTemplate.Height = 100;

            foreach (DataGridViewColumn col in dgvProductos.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvProductos.Columns["Imagen"].Width = 200;
        }
    }
}

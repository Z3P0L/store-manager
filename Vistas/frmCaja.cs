﻿using System;
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
    public partial class frmCaja : Form
    {
        database cn;
        DataTable dt;
        public frmCaja()
        {
            InitializeComponent();
            dataGridViewDesign();

            cn = new database();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Principal
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (CoreDelSistema.UsuarioLogueado.legajo == -1)
            {
                sesionCerrada();
            }
            else
            {
                sesionAbierta();
            }
        }

        private void sesionCerrada()
        {
            btnAcceder.Visible = true;

            btnClientes.Enabled = false;
            btnProducto.Enabled = false;
            btnVentas.Enabled = false;
        }

        private void sesionAbierta()
        {
            btnAcceder.Visible = false;

            btnClientes.Enabled = true;
            btnProducto.Enabled = true;
            btnVentas.Enabled = true;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                sesionAbierta();
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmVisualizarProductos main = new frmVisualizarProductos();
            this.Hide();
            main.Show();
        }
    }
}

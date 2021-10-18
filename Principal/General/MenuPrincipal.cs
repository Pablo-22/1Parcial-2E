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
    public partial class frmMenuPrincipal : frmBase
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (Core.UsuarioLogueado != null)
            {
                SesionAbierta(true);
            }
            else
            {
                SesionAbierta(false);
            }
        }

        private void SesionAbierta(bool toggle)
        {
            btnAcceder.Visible = !toggle;
            btnCerrarSesion.Visible = toggle;

            btnClientes.Enabled = toggle;
            btnProducto.Enabled = toggle;
            btnVentas.Enabled = toggle;
            btnUsuarios.Enabled = toggle;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentasBase verVentas = new frmVentasBase();
            this.Hide();
            verVentas.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                SesionAbierta(true);
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmVisualizarProductos main = new frmVisualizarProductos();
            this.Hide();
            main.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmVisualizarClientes verClientes = new frmVisualizarClientes();
            this.Hide();
            verClientes.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Core.UsuarioLogueado = null;
            SesionAbierta(false);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (Core.UsuarioLogueado is Administrador)
            {
                frmUsuarios_VistaDeAdmin verUsuarios = new frmUsuarios_VistaDeAdmin();
                this.Hide();
                verUsuarios.Show();
            }
            else
            {
                frmUsuarios_VistaDeEmpleado verUsuarios = new frmUsuarios_VistaDeEmpleado();
                this.Hide();
                verUsuarios.Show();
            }
        }
    }
}

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
    public partial class frmVisualizarClientes : frmClientesBase
    {
        public frmVisualizarClientes()
        {
            InitializeComponent();
        }

        private void frmVisualizarClientes_Load(object sender, EventArgs e)
        {
            CargarDatosDeCliente(IndiceActualCliente);

            ModoEdicion(false);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            IndiceActualCliente++;
            CargarDatosDeCliente(IndiceActualCliente);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            IndiceActualCliente--;
            CargarDatosDeCliente(IndiceActualCliente);
        }

        private void btnAñadirCliente_Click(object sender, EventArgs e)
        {
            if (Core.UsuarioLogueado is Administrador)
            {
                frmAniadirCliente editar = new frmAniadirCliente();
                editar.ShowDialog();
                if (editar.DialogResult == DialogResult.OK)
                {
                    CargarDatosDeCliente(IndiceActualCliente);
                }
            }
            else
            {
                MessageBox.Show("Permisos insuficientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarCliente editar = new frmEditarCliente();
            editar.ShowDialog();
            if(editar.DialogResult == DialogResult.OK)
            {
                CargarDatosDeCliente(IndiceActualCliente);
            }
        }
    }
}
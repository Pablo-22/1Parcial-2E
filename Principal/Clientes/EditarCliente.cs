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
    public partial class frmEditarCliente : frmClientesBase
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void EditarClientes_Load(object sender, EventArgs e)
        {
            CargarDatosDeCliente(IndiceActualCliente);
            ModoEdicion(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ModoEdicion(false);
            CargarDatosDeCliente(IndiceActualCliente);
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (CamposRellenos() == true)
            {
                Cliente nuevoCliente = new Cliente(float.Parse(txtDistancia.Text), int.Parse(txtNumeroCliente.Text));
                if (nuevoCliente.ValidarTodoCliente(txtNombre.Text, txtEmail.Text, txtSaldo.Text) == true)
                {
                    nuevoCliente.SetearTodoCliente(txtNombre.Text, txtEmail.Text, float.Parse(txtSaldo.Text));

                    Core.Clientes[IndiceActualCliente] = nuevoCliente;
                    ModoEdicion(false);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}

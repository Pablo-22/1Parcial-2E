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
    public partial class frmAniadirCliente : frmClientesBase
    {
        public frmAniadirCliente()
        {
            InitializeComponent();
        }

        private void frmAñadirCliente_Load(object sender, EventArgs e)
        {
            ModoEdicion(true);
        }

        /// <summary>
        /// Añade un cliente nuevo a la lista, en base al valor de los campos del form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (CamposRellenos() == true)
            {
                Cliente nuevoCliente = new Cliente();
                if (nuevoCliente.ValidarTodoCliente(txtNombre.Text, txtEmail.Text, txtSaldo.Text) == true )
                {
                    nuevoCliente.SetearTodoCliente(txtNombre.Text, txtEmail.Text, float.Parse(txtSaldo.Text));

                    IndiceActualCliente = Core.GuardarCliente(nuevoCliente);
                    ModoEdicion(false);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Romina";
            txtEmail.Text = "romina_23@gmail.com";
            txtSaldo.Text = "2890";
        }
    }
}

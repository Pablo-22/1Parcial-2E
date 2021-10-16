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
        //List<string> listaDeNombres;
        AutoCompleteStringCollection listaDeNombres;


        public frmVisualizarClientes()
        {
            InitializeComponent();
            listaDeNombres = new AutoCompleteStringCollection();
        }

        private void frmVisualizarClientes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Core.Clientes.Count; i++)
            {
                listaDeNombres.Add(Core.Clientes[i].Nombre);
            }

            txtNombre.AutoCompleteCustomSource = listaDeNombres;

            CargarDatosDeCliente(IndiceActualCliente);

            ModoEdicion(false);
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ActivarModoClientesConMismoNombre()
        {
            btnAnterior.Visible = true;
            btnSiguiente.Visible = true;
        }

        private void DesactivarModoClientesConMismoNombre()
        {
            btnAnterior.Visible = false;
            btnSiguiente.Visible = false;
        }

        /*
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListaDeIndicesConElNombreBuscado = CoreDelSistema.BuscarClientesPorNombre(txtNombre.Text);
            if (ListaDeIndicesConElNombreBuscado.Count > 1)
            {
                //HAY CLIENTES CON EL MISMO NOMBRE
                CargarDatosDeClienteConMismoNombre(IndiceActualClienteDeNombresRepetidos);
            }
            else if(ListaDeIndicesConElNombreBuscado.Count > 0)
            {
                //NO HAY CLIENTES CON EL MISMO NOMBRE
                CargarDatosDeCliente(ListaDeIndicesConElNombreBuscado[0]);
            }
        }
        */

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
            frmAniadirCliente editar = new frmAniadirCliente();
            editar.ShowDialog();
            if (editar.DialogResult == DialogResult.OK)
            {
                CargarDatosDeCliente(IndiceActualCliente);
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
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
    public partial class frmClientesBase : Form
    {

        static int indiceActualCliente = 0;
        static List<int> listaDeIndicesConElNombreBuscado;
        static int indiceActualDeNombresRepetidos = 0;


        public int IndiceActualCliente
        {
            get
            {
                return indiceActualCliente;
            }
            set
            {
                indiceActualCliente = value;
            }
        }

        public int IndiceActualDeNombresRepetidos
        {
            get
            {
                return indiceActualDeNombresRepetidos;
            }
            set
            {
                indiceActualDeNombresRepetidos = value;
            }
        }

        public static List<int> ListaDeIndicesConElNombreBuscado
        {
            get
            {
                return listaDeIndicesConElNombreBuscado;
            }
            set
            {
                listaDeIndicesConElNombreBuscado = value; 
            }
        }

        public frmClientesBase()
        {
            InitializeComponent();
            listaDeIndicesConElNombreBuscado = new List<int>();
        }


        protected void LimpiarForm()
        {
            txtNombre.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtSaldo.Text = "";
            txtDistancia.Text = "";
        }

        /// <summary>
        /// Utiliza una lógica "toggle" para setear si los campos se pueden editar o no.
        /// </summary>
        /// <param name="toggle"></param>
        protected void ModoEdicion(bool toggle)
        {
            txtNombre.ReadOnly = !toggle;
            txtEmail.ReadOnly = !toggle;
            txtSaldo.ReadOnly = !toggle;
        }

        /// <summary>
        /// Comprueba que los campos no estén vacíos
        /// </summary>
        /// <returns>false si álguno está vacío, true si ninguno está vacío.</returns>
        protected bool CamposRellenos()
        {
            if (txtNombre.Text == "" || txtEmail.Text == "" || txtSaldo.Text == "")
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Si encuentra cliente en el índice pasado, carga todos los datos del cliente en el form
        /// Si no lo encuentra, vuelve al último elemento, o al primero, según el valor del index.
        /// </summary>
        /// <param name="index"></param>
        protected void CargarDatosDeCliente(int index)
        {
            if (Core.BuscarIndiceCliente(index) == true)
            {
                txtNombre.Text = Core.Clientes[index].Nombre;
                txtEmail.Text = Core.Clientes[index].Email;
                txtSaldo.Text = Core.Clientes[index].Saldo.ToString();
                txtDistancia.Text = Core.Clientes[index].Distancia.ToString();
                txtNumeroCliente.Text = Core.Clientes[index].IdCliente.ToString();

                //lstHistorial.DataSource = Core.Clientes[index].HistorialDeCompras.Values;
            }
            else
            {
                if (IndiceActualCliente > -1)
                {
                    IndiceActualCliente = 0;
                }
                else
                {
                    IndiceActualCliente = Core.Clientes.Count - 1;
                }

                CargarDatosDeCliente(IndiceActualCliente);
            }
        }

        /*
        protected void CargarDatosDeClienteConMismoNombre(int index)
        {
            if (index > -1)
            {
                if (index < ListaDeIndicesConElNombreBuscado.Count)
                {
                    CargarDatosDeCliente(ListaDeIndicesConElNombreBuscado[index]);
                }
                else
                {
                    IndiceActualDeNombresRepetidos = ListaDeIndicesConElNombreBuscado.Count - 1;
                    CargarDatosDeCliente(ListaDeIndicesConElNombreBuscado[IndiceActualDeNombresRepetidos]);
                }
            }
            else
            {
                IndiceActualDeNombresRepetidos = 0;
                CargarDatosDeCliente(ListaDeIndicesConElNombreBuscado[IndiceActualDeNombresRepetidos]);
            }
        }
        */

        private void frmClientesBase_Load(object sender, EventArgs e)
        {

        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}

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

        protected void ModoEdicion(bool toggle)
        {
            bool soloLectura = true;
            if (toggle == true)
            {
                soloLectura = false;
            }

            txtNombre.ReadOnly = soloLectura;
            txtEmail.ReadOnly = soloLectura;
            txtSaldo.ReadOnly = soloLectura;
            txtDistancia.ReadOnly = soloLectura;
        }

        protected bool CamposValidos()
        {
            if (txtNombre.Text == "" || txtEmail.Text == "" || txtSaldo.Text == "" || txtDistancia.Text == "")
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Si encuentra producto en el índice pasado, carga todos los datos del producto en el form
        /// Si no lo encuentra, vuelve al último elemento, o al primero, según el valor del index.
        /// </summary>
        /// <param name="index"></param>
        protected void CargarDatosDeCliente(int index)
        {
            if (CoreDelSistema.BuscarIndiceCliente(index) == true)
            {
                txtNombre.Text = CoreDelSistema.Clientes[index].Nombre;
                txtEmail.Text = CoreDelSistema.Clientes[index].Email;
                txtSaldo.Text = CoreDelSistema.Clientes[index].Saldo.ToString();
                txtDistancia.Text = CoreDelSistema.Clientes[index].Distancia.ToString();
                txtNumeroCliente.Text = CoreDelSistema.Clientes[index].IdCliente.ToString();
                //lstHistorial.DataSource = CoreDelSistema.Clientes[index];
            }
            else
            {
                if (IndiceActualCliente > -1)
                {
                    IndiceActualCliente = 0;
                }
                else
                {
                    IndiceActualCliente = CoreDelSistema.Clientes.Count - 1;
                }

                CargarDatosDeCliente(IndiceActualCliente);
            }
        }

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

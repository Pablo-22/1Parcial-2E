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
    public partial class frmAniadirVenta : Form
    {
        public frmAniadirVenta()
        {
            InitializeComponent();
        }

        private void CargarListas()
        {
            lstClientes.DataSource = Core.Clientes;
            lstProductos.DataSource = Almacen.Productos;

            lstClientes.Refresh();
            lstProductos.Refresh();
        }

        private bool CamposRellenos()
        {
            if (cmbMetodoDePago.Text == "" || dateFechaDeVenta.Value > DateTime.Now)
            {
                return false;
            }
            return true;
        }

        private void CargarMetodosDePago()
        {
            int metodosDePago = Enum.GetNames(typeof(Venta.MetodoDePago)).Length;

            for (int i = 0; i < metodosDePago; i++)
            {
                cmbMetodoDePago.Items.Add((Venta.MetodoDePago)i);
            }
        }

        private void AjustarCantidad()
        {
            Producto productoExtraido = (Producto)lstProductos.SelectedItem;

            if (productoExtraido.Cantidad < numCantidadDeUnidades.Value)
            {
                numCantidadDeUnidades.Value = productoExtraido.Cantidad;
            }
            else
            {
                if (numCantidadDeUnidades.Value < 1)
                {
                    numCantidadDeUnidades.Value = 1;
                }
            }
        }

        private void frmAñadirVenta_Load(object sender, EventArgs e)
        {
            CargarListas();
            CargarMetodosDePago();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void numCantidadDeUnidades_ValueChanged(object sender, EventArgs e)
        {
            AjustarCantidad();
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AjustarCantidad();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (CamposRellenos() == true)
            {
                Cliente clienteExtraido = (Cliente)lstClientes.SelectedItem;

                Producto productoExtraido = (Producto)lstProductos.SelectedItem;
                productoExtraido.Cantidad = (int)numCantidadDeUnidades.Value;

                try
                {
                    
                    Venta venta = new Venta(clienteExtraido.IdCliente, (Venta.MetodoDePago)cmbMetodoDePago.SelectedItem, productoExtraido, dateFechaDeVenta.Value);
                    Almacen.ConfirmarCondicionesDeVenta(clienteExtraido.IdCliente, venta);
                    clienteExtraido.Saldo -= venta.PrecioTotal;

                    Core.Clientes[Core.BuscarClienteporId(clienteExtraido.IdCliente)] = clienteExtraido;
            
                    Almacen.Ventas.Add(venta);

                    //Reproducir sonido
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"notification-sound.wav");
                    player.Play();

                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("No se ha completado la venta. - Por favor, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Dato/s inválido/s - Por favor, intente nuevamente", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
    }
}

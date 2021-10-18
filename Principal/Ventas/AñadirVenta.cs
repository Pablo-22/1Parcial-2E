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
    public partial class frmAniadirVenta : frmBase
    {
        private int indiceDeProductoAVender = 0;
        public frmAniadirVenta()
        {
            InitializeComponent();
        }

        public frmAniadirVenta(int indiceDeProducto) :this()
        {
            this.indiceDeProductoAVender = indiceDeProducto;
        }

        private void CargarListas()
        {
            lstClientes.DataSource = Core.Clientes;
            lstProductos.DataSource = Almacen.Productos;

            lstProductos.SelectedItem = Almacen.Productos[indiceDeProductoAVender];

            lstClientes.Refresh();
            lstProductos.Refresh();
        }

        private bool CamposRellenos()
        {
            if (cmbMetodoDePago.Text == "" || dateFechaDeVenta.Value > DateTime.Now || numCantidadDeUnidades.Value < 1)
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
                    numCantidadDeUnidades.Value = 0;
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
                Producto productoSeleccionado = (Producto)lstProductos.SelectedItem;


                Producto productoDeVenta = new Producto(productoSeleccionado.IdProducto);
                 productoDeVenta.SetearTodo(productoSeleccionado.Nombre, productoSeleccionado.Precio, 
                     productoSeleccionado.Marca, productoSeleccionado.TipoDeAnimal, productoSeleccionado.TipoDeProducto, 
                     productoSeleccionado.Descripcion, productoSeleccionado.Cantidad, productoSeleccionado.Peso);

                productoDeVenta.Cantidad = (int)numCantidadDeUnidades.Value;

                try
                {
                    
                    Venta venta = new Venta(clienteExtraido.IdCliente, (Venta.MetodoDePago)cmbMetodoDePago.SelectedItem, productoDeVenta, dateFechaDeVenta.Value);
                    Almacen.ConfirmarCondicionesDeVenta(clienteExtraido.IdCliente, venta);
                    
                    Empleado empleado = (Empleado)Core.UsuarioLogueado;
                    empleado.RealizarVenta(venta);
            
                    Almacen.GuardarVenta(venta);

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

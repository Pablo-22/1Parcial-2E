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
    public partial class frmVentasBase : frmBase
    {
        public frmVentasBase()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            lstVentas.DataSource = Almacen.Ventas;
            lstVentas.Refresh();
        }

        /// <summary>
        /// Lleva al formulario para añadir una venta, y actualiza la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            frmAniadirVenta editar = new frmAniadirVenta();
            editar.ShowDialog();
            if (editar.DialogResult == DialogResult.OK)
            {
                lstVentas.DataSource = null;
                lstVentas.DataSource = Almacen.Ventas;
                lstVentas.Refresh();
            }
        }

        /// <summary>
        /// Elimina la venta seleccionada en el listBox de la lista de ventas, y refresca el listBox
        /// Si el usuario lo decide, puede devolverle el dinero al cliente (en su saldo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (Core.UsuarioLogueado is Administrador)
            {
                int indiceDeLaVentaAExtraer;
                Venta ventaExtraida = (Venta)lstVentas.SelectedItem;
                indiceDeLaVentaAExtraer = Almacen.BuscarVentaPorId(ventaExtraida.IdVenta);
                DialogResult result = MessageBox.Show("¿Desea devolver el dinero al cliente?", "Eliminar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Core.Clientes[Core.BuscarClienteporId(ventaExtraida.IdCliente)].Saldo += ventaExtraida.PrecioTotal;
                }
                Almacen.Ventas.RemoveAt(indiceDeLaVentaAExtraer);
                lstVentas.DataSource = null;
                lstVentas.DataSource = Almacen.Ventas;
                lstVentas.Refresh();
            }
            else
            {
                MessageBox.Show("Permisos insuficientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
        }

        /// <summary>
        /// Extrae la venta seleccionada del list box y la exporta a un txt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportarTicket_Click(object sender, EventArgs e)
        {
            Empleado usuarioLogueado = (Empleado)Core.UsuarioLogueado;
            Venta ventaExtraida = (Venta)lstVentas.SelectedItem;

            usuarioLogueado.ExportarVenta( ventaExtraida );

            MessageBox.Show("Ticket de venta exportado", "¡Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

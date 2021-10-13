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
    public partial class frmVentasBase : Form
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

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            int indiceDeLaVentaAExtraer;
            Venta ventaExtraida = (Venta)lstVentas.SelectedItem;
            indiceDeLaVentaAExtraer = Almacen.BuscarVentaporId(ventaExtraida.IdVenta);
            Almacen.Ventas.RemoveAt(indiceDeLaVentaAExtraer);
            lstVentas.DataSource = null;
            lstVentas.DataSource = Almacen.Ventas;
            lstVentas.Refresh();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
        }
    }
}

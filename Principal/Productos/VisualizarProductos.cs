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
    public partial class frmVisualizarProductos : frmProductosBase
    {
        public frmVisualizarProductos()
        {
            InitializeComponent();
        }

        private void VisualizarProductos_Load(object sender, EventArgs e)
        {
            DesactivarModoEdicion();
            lblCantidadProductos.Text = "/" + Almacen.Productos.Count.ToString();
            CargarCategorias();
            CargarDatosDeProducto(IndiceActualProducto);
        }

        private void btnVender1_Click(object sender, EventArgs e)
        { }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            frmEditarProducto editar = new frmEditarProducto();
            editar.ShowDialog();
            if (editar.DialogResult == DialogResult.OK)
            {
                CargarDatosDeProducto(IndiceActualProducto);
            }
        }

        private void btnAniadir1_Click(object sender, EventArgs e)
        {
            frmAniadirProducto editar = new frmAniadirProducto();
            editar.ShowDialog();
            if (editar.DialogResult == DialogResult.OK)
            {
                CargarDatosDeProducto(IndiceActualProducto);
            }
        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
            IndiceActualProducto++;
            CargarDatosDeProducto(IndiceActualProducto);
        }

        private void btnAnterior1_Click(object sender, EventArgs e)
        {
            IndiceActualProducto--;
            CargarDatosDeProducto(IndiceActualProducto);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {  }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

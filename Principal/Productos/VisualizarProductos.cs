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
            CargarDatosDeProducto(IndiceActual);
        }

        private void btnVender1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            frmEditarProducto editar = new frmEditarProducto();
            editar.ShowDialog();
            if (editar.DialogResult == DialogResult.OK)
            { 
                
            }
        }

        private void btnAniadir1_Click(object sender, EventArgs e)
        {
            frmEditarProducto editar = new frmEditarProducto();
            editar.ShowDialog();
            if (editar.DialogResult == DialogResult.OK)
            {
                
            }
        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
            IndiceActual++;
            CargarDatosDeProducto(IndiceActual);
        }

        private void btnAnterior1_Click(object sender, EventArgs e)
        {
            IndiceActual--;
            CargarDatosDeProducto(IndiceActual);
        }
    }
}

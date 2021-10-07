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
    public partial class frmEditarProducto : frmProductos
    {
        private static int indiceActual;

        public frmEditarProducto()
        {
            InitializeComponent();
        }

        public frmEditarProducto(int indice)
        {
            InitializeComponent();
            indiceActual = indice;
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarDatosDeProducto(indiceActual);

            txtNombre.ReadOnly = false;
            txtPrecio.ReadOnly = false;
            txtMarca.ReadOnly = false;
            rtxtDescripcion.ReadOnly = false;
            txtStock.ReadOnly = false;

            btnSiguiente.Visible = false;
            btnAnterior.Visible = false;
            btnAniadirProducto.Visible = false;
            btnEditar.Visible = false;
            btnVender.Visible = false;


            btnAceptar.Visible = true;
            btnCancelar.Visible = true;

            cmbCategoriaProducto.Enabled = true;
            cmbCategoriaAnimal.Enabled = true;
        }

        private void btnAceptarEdicion_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto(txtNombre.Text, float.Parse(txtPrecio.Text),
                    txtMarca.Text, (Producto.CategoriaAnimal)cmbCategoriaAnimal.SelectedItem, (Producto.CategoriaProducto)cmbCategoriaProducto.SelectedItem,
                    rtxtDescripcion.Text, int.Parse(txtStock.Text));

            Almacen.Productos[indiceActual] = nuevoProducto;

            //Cambios visuales
            btnCancelarEdicion_Click(null, null);
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            //Cambios visuales
            DesactivarModoEdicion();

            btnAniadirProducto.Visible = true;
            btnEditar.Visible = true;
            btnVender.Visible = true;
            btnAnterior.Visible = true;
            btnSiguiente.Visible = true;

            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            btnAutocompletarProducto.Visible = false;

            btnAniadirProducto.Text = "Añadir producto";

            CargarDatosDeProducto(indiceActual);
        }
    }
}

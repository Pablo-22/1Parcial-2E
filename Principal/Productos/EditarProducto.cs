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
    public partial class frmEditarProducto : frmProductosBase
    {

        public frmEditarProducto()
        {
            InitializeComponent();
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarDatosDeProducto(IndiceActualProducto);
            ActivarModoEdicion();
        }

        private void btnAceptarEdicion_Click(object sender, EventArgs e)
        {
            if (CamposValidos() == true)
            {
                Producto nuevoProducto = new Producto(txtNombre.Text, float.Parse(txtPrecio.Text),
                        txtMarca.Text, (Producto.CategoriaAnimal)cmbCategoriaAnimal.SelectedItem, (Producto.CategoriaProducto)cmbCategoriaProducto.SelectedItem,
                        rtxtDescripcion.Text, int.Parse(txtcantidad.Text), float.Parse(txtPeso.Text));

                Almacen.Productos[IndiceActualProducto] = nuevoProducto;

                //Cambios visuales
                DesactivarModoEdicion();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            //Cambios visuales
            DesactivarModoEdicion();

            CargarDatosDeProducto(IndiceActualProducto);
            this.DialogResult = DialogResult.Cancel;
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class frmAniadirProducto : frmProductosBase
    {
        public frmAniadirProducto()
        {
            InitializeComponent();
        }

        private void frmAniadirProducto_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            LimpiarForm();
            ActivarModoEdicion();
        }

        private void btnAceptar1_Click(object sender, EventArgs e)
        {
            if (CamposValidos() == true)
            {
                //Construyo un nuevo producto a partir de los datos cargados en los campos del form.
                Producto nuevoProducto = new Producto(txtNombre.Text, float.Parse(txtPrecio.Text),
                txtMarca.Text, (Producto.CategoriaAnimal)cmbCategoriaAnimal.SelectedItem, (Producto.CategoriaProducto)cmbCategoriaProducto.SelectedItem,
                rtxtDescripcion.Text, int.Parse(txtcantidad.Text), float.Parse(txtPeso.Text));

                //Aniadir producto devuelve el índice del producto añadido.
                IndiceActualProducto = Almacen.AniadirProducto(nuevoProducto);
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Pecera";
            txtPrecio.Text = "750";
            txtMarca.Text = "Fishi";
            rtxtDescripcion.Text = "Pecera de acrílico transparente, esférica y con capacidad de 10 litros.";
            txtcantidad.Text = "12";
            cmbCategoriaAnimal.SelectedItem = "Peces";
            cmbCategoriaProducto.SelectedItem = "Otro";
        }
    }
}

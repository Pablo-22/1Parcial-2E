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
            if (CamposRellenos() == true)
            {
                Producto nuevoProducto = new Producto();

                if (nuevoProducto.ValidarTodoProducto(txtNombre.Text,txtPrecio.Text, txtMarca.Text, 
                    rtxtDescripcion.Text, txtcantidad.Text, txtPeso.Text))
                {
                    //Seteo el producto a partir de los datos cargados en los campos del form, previamente validados.
                    nuevoProducto.SetearTodo(txtNombre.Text, float.Parse(txtPrecio.Text),
                    txtMarca.Text, (Producto.CategoriaAnimal)cmbCategoriaAnimal.SelectedItem, (Producto.CategoriaProducto)cmbCategoriaProducto.SelectedItem,
                    rtxtDescripcion.Text, int.Parse(txtcantidad.Text), float.Parse(txtPeso.Text));

                    //Guardar producto devuelve el índice del producto añadido.
                    IndiceActualProducto = Almacen.GuardarProducto(nuevoProducto);

                    //Reproducir sonido
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"notification-sound.wav");
                    player.Play();

                    this.DialogResult = DialogResult.OK;
                }

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
            cmbCategoriaAnimal.SelectedIndex = 3;
            cmbCategoriaProducto.SelectedIndex = 5;
            txtPeso.Text = "2";
        }
    }
}

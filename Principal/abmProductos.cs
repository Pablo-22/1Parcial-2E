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
    public partial class frmProductos : Form
    {
        static int indiceActual = 0;

        public frmProductos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Si encuentra producto en el índice pasado, carga todos los datos del producto en el form
        /// Si no lo encuentra, vuelve al último elemento, o al primero, según el valor del index.
        /// </summary>
        /// <param name="index"></param>
        protected void CargarDatosDeProducto(int index)
        {
            if (Almacen.BuscarIndiceProducto(index) == true)
            {
                txtNombre.Text = Almacen.Productos[index].Nombre;
                txtPrecio.Text = Almacen.Productos[index].Precio.ToString();
                txtMarca.Text = Almacen.Productos[index].Marca;
                rtxtDescripcion.Text = Almacen.Productos[index].Descripcion;
                txtStock.Text = Almacen.Productos[index].Stock.ToString();
                cmbCategoriaAnimal.SelectedIndex = (int)Almacen.Productos[index].TipoDeAnimal;
                cmbCategoriaProducto.SelectedIndex = (int)Almacen.Productos[index].TipoDeProducto;
                lblCantidadProductos.Text = (index + 1) + "/" + Almacen.Productos.Count.ToString();
            }
            else
            {
                if (indiceActual > -1)
                {
                    indiceActual = 0;
                }
                else
                {
                    indiceActual = Almacen.Productos.Count - 1;
                }

                CargarDatosDeProducto(indiceActual);
            }
        }

        protected void CargarCategorias()
        {
            var categoriasDeAnimales = Enum.GetNames(typeof(Producto.CategoriaAnimal)).Length;
            var categoriasDeProductos = Enum.GetNames(typeof(Producto.CategoriaProducto)).Length;

            for (int i = 0; i < categoriasDeAnimales; i++)
            {
                cmbCategoriaAnimal.Items.Add((Producto.CategoriaAnimal)i);
            }

            for (int i = 0; i < categoriasDeProductos; i++)
            {
                cmbCategoriaProducto.Items.Add((Producto.CategoriaProducto)i);
            }
        }

        protected void LimpiarForm()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtMarca.Text = "";
            rtxtDescripcion.Text = "";
            txtStock.Text = "";
            cmbCategoriaAnimal.Text = "Animal";
            cmbCategoriaProducto.Text = "Tipo de producto";
            lblCantidadProductos.Text = "";
        }

        protected void ActivarModoEdicion()
        {
            txtNombre.ReadOnly = false;
            txtPrecio.ReadOnly = false;
            txtMarca.ReadOnly = false;
            rtxtDescripcion.ReadOnly = false;
            txtStock.ReadOnly = false;
            cmbCategoriaAnimal.Enabled = true;
            cmbCategoriaProducto.Enabled = true;
        }

        protected void DesactivarModoEdicion()
        {
            txtNombre.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            txtMarca.ReadOnly = true;
            rtxtDescripcion.ReadOnly = true;
            txtStock.ReadOnly = true;
            cmbCategoriaAnimal.Enabled = false;
            cmbCategoriaProducto.Enabled = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblCantidadProductos.Text = "/" + Almacen.Productos.Count.ToString();
            CargarCategorias();
            CargarDatosDeProducto(0);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DesactivarModoEdicion();
            indiceActual++;
            CargarDatosDeProducto(indiceActual);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            DesactivarModoEdicion();
            indiceActual--;
            CargarDatosDeProducto(indiceActual);
        }

        private void btnAniadirProducto_Click(object sender, EventArgs e)
        {
            if (btnAniadirProducto.Text == "Aceptar")
            {
                //Construyo un nuevo producto a partir de los datos cargados en los campos del form.
                Producto nuevoProducto = new Producto(txtNombre.Text, float.Parse(txtPrecio.Text),
                    txtMarca.Text, (Producto.CategoriaAnimal)cmbCategoriaAnimal.SelectedItem, (Producto.CategoriaProducto)cmbCategoriaProducto.SelectedItem,
                    rtxtDescripcion.Text, int.Parse(txtStock.Text));

                //Aniadir producto devuelve el índice del producto añadido.
                indiceActual = Almacen.AniadirProducto(nuevoProducto);
                CargarDatosDeProducto(indiceActual);

                //Cambios visuales
                btnAniadirProducto.Text = "Añadir producto";

                btnAutocompletarProducto.Visible = false;
                btnCancelar.Visible = false;

                btnVender.Visible = true;
                btnEditar.Visible = true;
                btnSiguiente.Visible = true;
                btnAnterior.Visible = true;

                DesactivarModoEdicion();

            }
            else
            {
                //Cambios visuales
                LimpiarForm();
                ActivarModoEdicion();
                btnAniadirProducto.Text = "Aceptar";

                btnSiguiente.Visible = false;
                btnAnterior.Visible = false;
                btnEditar.Visible = false;
                btnVender.Visible = false;

                btnCancelar.Visible = true;
                btnAutocompletarProducto.Visible = true;
            }
        }

        private void btnAutocompletarProducto_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Pecera";
            txtPrecio.Text = "750";
            txtMarca.Text = "Fishi";
            rtxtDescripcion.Text = "Pecera de acrílico transparente, esférica y con capacidad de 10 litros.";
            txtStock.Text = "12";
            cmbCategoriaAnimal.SelectedItem = "Peces";
            cmbCategoriaProducto.SelectedItem = "Otro";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        { }

        private void btnCancelar_Click(object sender, EventArgs e)
        { }

        private void btnAceptar_Click(object sender, EventArgs e)
        { }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {

        }
    }
}

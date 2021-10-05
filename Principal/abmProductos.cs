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
    public partial class frmPrincipal : Form
    {
        static int indiceActual = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void CargarDatosDeProducto(int index)
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
                lblCantidadProductos.Text = (index + 1) + lblCantidadProductos.Text;
            }
            else
            {
                indiceActual = 0;
                CargarDatosDeProducto(indiceActual);
            }
        }

        private void CargarCategorias()
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblCantidadProductos.Text = "/" + Almacen.Productos.Count.ToString();
            CargarCategorias();
            CargarDatosDeProducto(0);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            CargarDatosDeProducto(indiceActual++);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            CargarDatosDeProducto(indiceActual--);
        }
    }
}

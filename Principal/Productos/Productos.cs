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
    public partial class frmProductosBase : Form
    {
        static int indiceActual = 0;
        
        
        public int IndiceActual
        {
            get
            {
                return indiceActual;
            }
            set
            {
                indiceActual = value;
            }
        }



        public frmProductosBase()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
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
                if (IndiceActual > -1)
                {
                    IndiceActual = 0;
                }
                else
                {
                    IndiceActual = Almacen.Productos.Count - 1;
                }

                CargarDatosDeProducto(IndiceActual);
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

    }
}

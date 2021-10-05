using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string nombre;
        private float precio;
        private string marca;
        private CategoriaAnimal tipoDeAnimal;
        private CategoriaProducto tipoDeProducto;
        private string descripcion;
        private int stock;

        public Producto(string nombre, float precio, string marca, 
            CategoriaAnimal tipoDeAnimal, CategoriaProducto tipoDeProducto, 
            string descripcion, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.tipoDeAnimal = tipoDeAnimal;
            this.tipoDeProducto = tipoDeProducto;
            this.descripcion = descripcion;
            this.stock = stock;
        }

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Stock { get => stock; set => stock = value; }
        public CategoriaAnimal TipoDeAnimal { get => tipoDeAnimal; set => tipoDeAnimal = value; }
        public CategoriaProducto TipoDeProducto { get => tipoDeProducto; set => tipoDeProducto = value; }
        #endregion Propiedades

        public enum CategoriaAnimal
        {
            Aves,
            Perros,
            Gatos,
            Peces,
            Roedores,
            Reptiles
        }

        public enum CategoriaProducto
        {
            Alimento,
            Indumentaria,
            Juguetes,
            Transportadoras,
            Salud,
            Otro
        }


    }
}

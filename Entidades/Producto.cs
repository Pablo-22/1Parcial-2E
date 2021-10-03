using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Producto
    {
        private string nombre;
        private float precio;
        private string marca;
        private CategoriaAnimal tipoDeAnimal;
        private CategoriaProducto tipoDeProducto;
        private string descripción;
        private int stock;

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripción { get => descripción; set => descripción = value; }
        public int Stock { get => stock; set => stock = value; }
        internal CategoriaAnimal TipoDeAnimal { get => tipoDeAnimal; set => tipoDeAnimal = value; }
        internal CategoriaProducto TipoDeProducto { get => tipoDeProducto; set => tipoDeProducto = value; }
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
            Salud
        }


    }
}

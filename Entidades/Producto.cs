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
        private int cantidad;
        private float peso;
        private int idProducto;

        public Producto(string nombre, float precio, string marca, 
            CategoriaAnimal tipoDeAnimal, CategoriaProducto tipoDeProducto, 
            string descripcion, int cantidad, float peso)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.tipoDeAnimal = tipoDeAnimal;
            this.tipoDeProducto = tipoDeProducto;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.idProducto = CoreDelSistema.AsignarId();
            this.peso = peso;
        }

        #region Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if(ValidarNombre(nombre))
                {
                    nombre = value;
                }
            }
        }

        public float Precio { get => precio; set => precio = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public CategoriaAnimal TipoDeAnimal { get => tipoDeAnimal; set => tipoDeAnimal = value; }
        public CategoriaProducto TipoDeProducto { get => tipoDeProducto; set => tipoDeProducto = value; }
        public float Peso { get => peso; set => peso = value; }
        #endregion Propiedades


        private bool ValidarNombre(string nombre)
        {
            bool exit = false;
            if (string.IsNullOrEmpty(nombre) == false)
            {
                for (int i = 0; i < nombre.Length; i++)
                {
                    exit = true;
                    if (char.IsDigit(nombre[i]) == true)
                    {
                        exit = false;
                        break;
                    }

                }
            }
            return exit;
        }

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

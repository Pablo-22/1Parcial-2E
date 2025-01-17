﻿using System;
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


        public Producto(): this(Core.AsignarId())
        { }

        public Producto(int id)
        {
            this.idProducto = id;
        }

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
            this.idProducto = Core.AsignarId();
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
                if(ValidarNombre(value))
                {
                    nombre = value;
                }
                else
                {
                    this.nombre = "Nombre inválido";
                }
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if (ValidarPrecio(value))
                {
                    this.precio = value;
                }
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
            set
            {
                if (ValidarPeso(value))
                {
                    this.peso = value;
                }
                else
                {
                    this.peso = 1;
                }
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                if (ValidarCantidad(value))
                {
                    this.cantidad = value;
                }
                else
                {
                    this.cantidad = 1;
                }
            }
        }

        public int IdProducto
        {
            get { return this.idProducto; }
        }

        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                if(this.ValidarMarca(value))
                {
                    this.marca = value;
                }
                else
                {
                    this.marca = "Marca inválida";
                }

            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                if (this.ValidarDescripcion(value) == true)
                {
                    this.descripcion = value;
                }
                else
                {
                    this.descripcion = "Descripción inválida - Edite este campo";
                }

            }
        }

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

        /// <summary>
        /// Muestra los datos de un producto
        /// </summary>
        /// <returns>Retorna una cadena con los datos de un producto.</returns>
        public override string ToString()
        {
            StringBuilder producto = new StringBuilder();
            producto.Append("Nombre: " + this.Nombre);
            producto.Append("    ||    Marca: " + this.Marca);
            producto.Append("    ||    Precio: " + this.Precio);
            producto.Append("    ||    Stock: " + this.Cantidad);

            return producto.ToString();
        }

        /// <summary>
        /// Valida el nombre. En esta capa se realizan las validaciones de reglas de negocio.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>true si es válido, false si no es válido</returns>
        private bool ValidarNombre(string nombre)
        {
            if (Core.ValidarLetras(nombre) == true && nombre.Length < 20)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Valida la marca. En esta capa se realizan las validaciones de reglas de negocio.
        /// </summary>
        /// <param name="marca"></param>
        /// <returns>true si es válido, false si no es válido</returns>
        private bool ValidarMarca(string marca)
        {
            if (Core.ValidarLetras(marca) == true && marca.Length < 15)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Valida el precio. En esta capa se realizan las validaciones de reglas de negocio.
        /// </summary>
        /// <param name="precio"></param>
        /// <returns>true si es válido, false si no es válido</returns>
        private bool ValidarPrecio(float precio)
        {
            if (precio > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Valida el peso. En esta capa se realizan las validaciones de reglas de negocio.
        /// </summary>
        /// <param name="peso"></param>
        /// <returns>true si es válido, false si no es válido</returns>
        private bool ValidarPeso(float peso)
        {
            if (peso < 80)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Valida la descripción. En esta capa se realizan las validaciones de reglas de negocio.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>true si es válido, false si no es válido</returns>
        private bool ValidarDescripcion(string nombre)
        {
            if (nombre.Length < 255)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Valida la cantidad. En esta capa se realizan las validaciones de reglas de negocio.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns>true si es válido, false si no es válido</returns>
        private bool ValidarCantidad(int cantidad)
        {
            if (cantidad < 100)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// utiliza las validaciones para verificar que todos los parámetros sean válidos para crear un producto.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="descripcion"></param>
        /// <param name="cantidad"></param>
        /// <param name="peso"></param>
        /// <returns>true si es válido, false si no es válido</returns>
        public bool ValidarTodoProducto(string nombre, string precio, string marca, string descripcion, string cantidad, string peso)
        {
            if (Core.ValidarLetras(nombre) && Core.ValidarLetras(marca) 
                && Core.ValidarFlotante(precio) && Core.ValidarFlotante(peso) && Core.ValidarEntero(cantidad) )
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Utiliza las propiedades para escribir todos los datos del producto.
        /// De esta forma se aprovechan las validaciones de los setters.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="categoriaAnimal"></param>
        /// <param name="categoriaProducto"></param>
        /// <param name="descripcion"></param>
        /// <param name="cantidad"></param>
        /// <param name="peso"></param>
        public void SetearTodo(string nombre, float precio, string marca, Producto.CategoriaAnimal categoriaAnimal,
               Producto.CategoriaProducto categoriaProducto, string descripcion, int cantidad, float peso)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Marca = marca;
            this.Descripcion = descripcion;
            this.TipoDeAnimal = categoriaAnimal;
            this.TipoDeProducto = categoriaProducto;
            this.Cantidad = cantidad;
            this.Peso = peso;
        }
    }    
}

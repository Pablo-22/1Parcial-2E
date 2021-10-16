using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Usuario
    {
        public Empleado(string nombreDeUsuario, string password)
            : base(nombreDeUsuario, password)
        { }

        public Empleado() :base()
        { }

        public string EditarProducto()
        {
            /*
                private string nombre;
                private float precio;
                private string marca;
                private CategoriaAnimal tipoDeAnimal;
                private CategoriaProducto tipoDeProducto;
                private string descripcion;
                private int cantidad;
                private float peso;
                private int idProducto;
            */

            return "Permisos insuficientes";
        }

        public virtual void NuevoCliente()
        {
            Console.WriteLine("Desde Empleado");
        }

    }
}

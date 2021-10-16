using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Entidades
{
    public class Empleado : Usuario
    {
        public Empleado(string nombreDeUsuario, string password)
            : base(nombreDeUsuario, password)
        { }

        public Empleado() : base()
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

        protected virtual string UsuarioAFormatoCsv(Usuario usuarioAConvertir)
        {
            string permisos = "Empleado";
            StringBuilder usuario = new StringBuilder();
            usuario.Append(usuarioAConvertir.IdUsuario + ",");
            usuario.Append(usuarioAConvertir.NombreDeUsuario + ",");
            if (usuarioAConvertir is Administrador)
            {
                permisos = "Administrador";
            }
            usuario.Append(permisos);

            return usuario.ToString();
        }

        protected virtual string UsuariosAFormatoCsv()
        {
            StringBuilder usuarios = new StringBuilder();
            usuarios.AppendLine("Id,Nombre,Permisos");
            foreach (Usuario item in Core.Usuarios)
            {
                usuarios.AppendLine(UsuarioAFormatoCsv(item));
            }
            return usuarios.ToString();
        }


        public virtual void ExportarUsuarios()
        {
            string rutaCompleta = @"datos-de-usuarios.csv";
            string texto = this.UsuariosAFormatoCsv();
            File.WriteAllText(rutaCompleta, texto);
        }

        public virtual void ExportarVenta(Venta venta)
        {
            string rutaCompleta = @"ticket-de-compra.txt";
            string texto = venta.TicketDeCompra();
            File.WriteAllText(rutaCompleta, texto);
        }
    }
}
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

        public Empleado(int id) : base(id)
        { }

        /// <summary>
        /// Convierte un usuario a formato CSV.
        /// A diferencia de esta función en Administrador, esta no muestra la contraseña
        /// </summary>
        /// <param name="usuarioAConvertir"></param>
        /// <returns>Retorna los datos del usuario recibido en formato válido CSV</returns>
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

        /// <summary>
        /// Utiliza la función UsuarioAFormatoCsv para convertir TODOS los usuarios a CSV.
        /// Añade un encabezado.
        /// </summary>
        /// <returns> Retorna a todos los usuarios en formato CSV (sin contraseña)</returns>
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

        /// <summary>
        /// Exporta los datos de los usuarios en formato CSV a un archivo .csv
        /// </summary>
        public virtual void ExportarUsuarios()
        {
            string rutaCompleta = @"datos-de-usuarios.csv";
            string texto = this.UsuariosAFormatoCsv();
            File.WriteAllText(rutaCompleta, texto);
        }

        /// <summary>
        /// Exporta un ticket de venta a un archivo de texto.
        /// el nombre del archivo constará del id de la venta y el sufijo "-venta".
        /// Si el archivo ya existe, lo sobreescribe.
        /// </summary>
        /// <param name="venta"></param>
        public virtual void ExportarVenta(Venta venta)
        {
            string carpetaTickets = "tickets";
            string rutaTickets = "tickets\\" + venta.IdVenta.ToString() + "-venta.txt";

            if (!Directory.Exists(carpetaTickets))
            {
                Directory.CreateDirectory(carpetaTickets);
            }

            string texto = venta.TicketDeCompra();
            File.WriteAllText(@rutaTickets, texto);
        }

        /// <summary>
        /// Muestra los datos de un usuario (sin contraseña)
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Devuelve los datos en una cadena</returns>
        public virtual string MostrarUsuario(Usuario usuario)
        {
            StringBuilder user = new StringBuilder();
            user.Append("Nombre: " + usuario.NombreDeUsuario);
            if (usuario is Administrador)
            {
                user.Append(" --- Permisos: Administrador" );
            }
            else
            {
                user.Append(" --- Permisos: Empleado");
            }

            return user.ToString();
        }

        public override string ToString()
        {
            if (Core.UsuarioLogueado is Administrador)
            {
                Administrador usuarioLogueado = (Administrador)Core.UsuarioLogueado;
                return usuarioLogueado.MostrarUsuario(this);
            }
            else
            {
                Empleado usuarioLogueado = (Empleado)Core.UsuarioLogueado;
                return usuarioLogueado.MostrarUsuario(this);
            }
        }

        public void RealizarVenta(Venta venta)
        {
            Core.Clientes[Core.BuscarClienteporId(venta.IdCliente)].Saldo -= venta.PrecioTotal;
            Almacen.Productos[Almacen.BuscarProductoPorId(venta.ProductoVendido.IdProducto)].Cantidad -= venta.ProductoVendido.Cantidad;
        }
    }
}
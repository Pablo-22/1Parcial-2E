using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Empleado
    {
        public Administrador(string nombreDeUsuario, string password)
            : base(nombreDeUsuario, password)
        { }

        public Administrador()
            : base()
        { }

        public Administrador(int id)
            : base(id)
        { }


        /// <summary>
        /// Recibe los datos para crear un usuario nuevo, y lo 
        /// crea utilizando los setters para las validaciones necesarias, 
        /// que no se ejecutarían al utilizar directamente el constructor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="password"></param>
        /// <param name="nivelDeAcceso"></param>
        /// <returns></returns>
        public Usuario crearUsuario(int id, string nombre, string password, string nivelDeAcceso)
        {
            if (nivelDeAcceso == "Administrador")
            {
                Administrador usuarioEditado = new Administrador(id);
                usuarioEditado.NombreDeUsuario = nombre;
                usuarioEditado.Password = password;
                return usuarioEditado;
            }
            else
            {
                Empleado usuarioEditado = new Empleado(id);
                usuarioEditado.NombreDeUsuario = nombre;
                usuarioEditado.Password = password;
                return usuarioEditado;
            }
        }



        /// <summary>
        /// Convierte el usuario que recibe como parámetro a un formato CSV.
        /// A diferencia de la versión de la clase empleado, en esta se añade la password
        /// </summary>
        /// <param name="usuarioAConvertir"></param>
        /// <returns></returns>
        protected override string UsuarioAFormatoCsv(Usuario usuarioAConvertir)
        {
            StringBuilder usuario = new StringBuilder();
            usuario.Append(base.UsuarioAFormatoCsv(usuarioAConvertir));
            usuario.Append("," + usuarioAConvertir.Password);

            return usuario.ToString();
        }

        /// <summary>
        /// Utiliza la función que convierte un usuario a CSV, 
        /// para convertir todos los usuarios registrados.
        /// </summary>
        /// <returns></returns>
        protected override string UsuariosAFormatoCsv()
        {
            StringBuilder usuarios = new StringBuilder();
            usuarios.AppendLine("Id,Nombre, Permisos, Password");
            foreach (Usuario item in Core.Usuarios)
            {
                usuarios.AppendLine(UsuarioAFormatoCsv(item));
            }
            return usuarios.ToString();
        }

        /// <summary>
        /// Muestra los datos de un usuario (sin contraseña)
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Devuelte los datos en una cadena</returns>
        public override string MostrarUsuario(Usuario usuario)
        {
            StringBuilder user = new StringBuilder();
            user.Append(base.MostrarUsuario(usuario));
            user.Append(" --- Contraseña: " + usuario.Password);

            return user.ToString();
        }
    }
}

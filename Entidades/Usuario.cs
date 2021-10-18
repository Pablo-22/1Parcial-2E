using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        private string password;

        #region Constructor
        public Usuario() : base()
        { }

        public Usuario(int id) : base(id)
        {  }

        public Usuario(string nombreDeUsuario) : base(nombreDeUsuario)
        { }

        public Usuario(string nombreDeUsuario, string password) : this(nombreDeUsuario)
        {
            this.password = password;
        }

        public Usuario(string nombreDeUsuario, string password, int id)
            : base(nombreDeUsuario, id)
        {
            this.password = password;
        }
        #endregion Constructor


        #region Propiedades
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if (this.ValidarContrasenia(value) == true)
                {
                    this.password = value;
                }
            }
        }
        #endregion Propiedades

        /// <summary>
        /// Valida la contraseña. En esta capa se realizan las validaciones de reglas de negocio.
        /// </summary>
        /// <param name="password"></param>
        /// <returns>true si es válido, false si no es válido</returns>
        private bool ValidarContrasenia(string password)
        {
            if (!string.IsNullOrEmpty(password) && password.Length < 20
                && password.Length > 6)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Muestra los datos de un usuario.
        /// Si el usuario logueado es administrador, incluirá la contraseña.
        /// Sirve para los listBox
        /// </summary>
        /// <returns>Retorna una cadena con los datos del usuario.</returns>
        public override string ToString()
        {
            StringBuilder datosDeUsuario = new StringBuilder();
            if (Core.UsuarioLogueado is Administrador)
            {
                Administrador user = (Administrador)Core.UsuarioLogueado;

                datosDeUsuario.AppendLine(user.MostrarUsuario(this) );
            }
            else
            {
                Empleado user = (Empleado)Core.UsuarioLogueado;
                foreach (Usuario usuario in Core.Usuarios)
                {
                    datosDeUsuario.AppendLine(user.MostrarUsuario(this));
                }
            }
            return datosDeUsuario.ToString();
        }

        public static explicit operator int(Usuario user)
        {
            return user.IdUsuario;
        }
    }
}


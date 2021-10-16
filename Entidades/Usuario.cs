using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string nombreDeUsuario;
        private string password;
        private int idUsuario;

        #region Constructor
        public Usuario()
        {
            this.nombreDeUsuario = null;
            this.password = null;
            this.idUsuario = Core.AsignarId();
        }

        public Usuario(string nombreDeUsuario, string password)
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.password = password;
            this.idUsuario = Core.AsignarId();
        }

        public Usuario(string nombreDeUsuario, string password, string celular, int id)
            : this(nombreDeUsuario, password)
        {
            this.idUsuario = id;
        }
        #endregion Constructor


        #region Propiedades
        public int IdUsuario
        {
            get
            {
                return this.idUsuario;
            }
        }


        public string NombreDeUsuario
        {
            get
            {
                return this.nombreDeUsuario;
            }
            set
            {
                if (this.ValidarNombre(value) == true)
                {
                    this.nombreDeUsuario = value;
                }
            }
        }

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


        private bool ValidarNombre(string nombre)
        {
            if (Core.ValidarLetras(password) == true && nombre != "admin" && nombre.Length < 20)
            {
                return true;
            }
            return false;
        }

        private bool ValidarContrasenia(string password)
        {
            if (!string.IsNullOrEmpty(password) && password.Length < 20
                && password.Length > 6)
            {
                return true;
            }
            return false;
        }
    }
}


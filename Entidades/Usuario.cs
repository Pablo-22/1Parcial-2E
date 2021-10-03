using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract class Usuario
    {
        private string nombreDeUsuario;
        private string password;
        private Permisos nivelDeAcceso;

        #region Constructor
        protected Usuario(string nombreDeUsuario, string password, Permisos nivelDeAcceso)
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.password = password;
            this.nivelDeAcceso = nivelDeAcceso;
        }
        #endregion Constructor

        #region Propiedades
        public string NombreDeUsuario
        {
            get
            {
                return this.nombreDeUsuario;
            }
            set
            {
                if(this.NivelDeAcceso == Permisos.Administrador)
                {
                    this.nombreDeUsuario = value;
                }
            }
        }

        public string Password
        {
            get
            {
                string password = "-";
                if (this.NivelDeAcceso == Permisos.Administrador)
                {
                    password = this.password;
                }
                return password;
            }
            set
            {
                if (this.NivelDeAcceso == Permisos.Administrador)
                {
                    this.password = value;
                }
            }
        }

        internal Permisos NivelDeAcceso
        {
            get
            {
                return this.nivelDeAcceso;
            }
            set
            {
                if (this.nivelDeAcceso == Permisos.Administrador)
                {
                    this.nivelDeAcceso = value;
                }
            }
        }
        #endregion Propiedades

        public enum Permisos { Administrador, Empleado, Cliente }

    }
}

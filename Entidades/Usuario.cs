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
        private ePermisos nivelDeAcceso;

        #region Constructor
        protected Usuario(string nombreDeUsuario, string password, ePermisos nivelDeAcceso)
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
                if(CoreDelSistema.UsuarioLogueado.NivelDeAcceso == ePermisos.Administrador)
                {
                    this.nombreDeUsuario = value;
                }
            }
        }

        public string Password
        {
            get
            {
                string password = "Permisos insuficientes";
                if (CoreDelSistema.UsuarioLogueado.NivelDeAcceso == ePermisos.Administrador)
                {
                    password = this.password;
                }
                return password;
            }
            set
            {
                if (CoreDelSistema.UsuarioLogueado.NivelDeAcceso == ePermisos.Administrador)
                {
                    this.password = value;
                }
            }
        }

        internal ePermisos NivelDeAcceso
        {
            get
            {
                return this.nivelDeAcceso;
            }
            set
            {
                if (CoreDelSistema.UsuarioLogueado.nivelDeAcceso == ePermisos.Administrador)
                {
                    this.nivelDeAcceso = value;
                }
            }
        }
        #endregion Propiedades

        public enum ePermisos { Administrador, Empleado }
    }
}

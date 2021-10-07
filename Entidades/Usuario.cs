using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario
    {
        private string nombreDeUsuario;
        private string password;
        public string celular;
        public int legajo;
        private ePermisos nivelDeAcceso;

        #region Constructor
        protected Usuario(string nombreDeUsuario, string password, string celular, ePermisos nivelDeAcceso)
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.password = password;
            this.legajo = CoreDelSistema.AsignarId();
            this.celular = celular;
            this.nivelDeAcceso = nivelDeAcceso;
        }

        protected Usuario(string nombreDeUsuario, string password, string celular, int legajo, ePermisos nivelDeAcceso)
            :this(nombreDeUsuario, password, celular, nivelDeAcceso)
        {
            this.legajo = legajo;
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
                if (CoreDelSistema.UsuarioLogueado.NivelDeAcceso == ePermisos.Administrador)
                {
                    return this.password;
                }
                return "";
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

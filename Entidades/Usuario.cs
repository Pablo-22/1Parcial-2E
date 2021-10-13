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
        private string celular;
        private int idUsuario;
        private ePermisos nivelDeAcceso;

        #region Constructor
        protected Usuario(string nombreDeUsuario, string password, string celular, ePermisos nivelDeAcceso)
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.password = password;
            this.idUsuario = CoreDelSistema.AsignarId();
            this.celular = celular;
            this.nivelDeAcceso = nivelDeAcceso;
        }

        protected Usuario(string nombreDeUsuario, string password, string celular, int id, ePermisos nivelDeAcceso)
            :this(nombreDeUsuario, password, celular, nivelDeAcceso)
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

        public string Celular
        {
            get
            {
                return this.celular;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false && value.Length < 15 )
                {
                    this.celular = value;
                }
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
                if(CoreDelSistema.ValidarNombre(value) == true && value != "admin")
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
                else
                {
                    return "Permisos insuficientes";
                }
            }
            set
            {
                if (CoreDelSistema.ValidarContrasenia(value) == false)
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
